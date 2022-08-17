using GestionDeTarjetas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using ClosedXML.Excel;
using GestionDeTarjetas.Models.ViewModels;
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace GestionDeTarjetas.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContextDB _context;

        public HomeController(ILogger<HomeController> logger, ContextDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("GenerarReporte")]
        public IActionResult GenerarReporte(DatosGeneracionArchivoViewModel model)
        {
            var connectionString = _context.Database.GetConnectionString();
            DataTable tablaInformacion = new DataTable();
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var adapter = new SqlDataAdapter())
                {

                    adapter.SelectCommand = new SqlCommand("dmGeneracionDocumento", conexion);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaDesde", model.Desde.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaHasta", model.Hasta.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@IdTarjeta", 1);
                    
                    adapter.Fill(tablaInformacion);
                }
                conexion.Close();                

                if(tablaInformacion.Rows.Count == 0) { return View("Index"); }

                using (var libro = new XLWorkbook())
                {
                    tablaInformacion.TableName = "DatosExcel";
                    var hoja = libro.Worksheets.Add(tablaInformacion);
                    hoja.ColumnsUsed().AdjustToContents();

                    using (var memoria = new MemoryStream())
                    {
                        libro.SaveAs(memoria);                                                

                        var nombreExcel = string.Concat("Recibos ", DateTime.Now.ToShortDateString(), ".xlsx");
                        return File(memoria.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nombreExcel);
                    }

                }
            }

        }
        [HttpPost]
        [Route("Grabar")]
        public async Task<IActionResult> Grabar(DatosGeneracionArchivoViewModel model)
        {
            //Verifico que se pueda utilizar el modulo de recibo de visa
            var conf = _context.DMPARM_CONF.Where(e => e.PARM_NOMBRE == "VISA").Select(e => new { e.PARM_UTILIZABLE, e.PARM_ID }).First();
            if (conf.PARM_UTILIZABLE == 0)
            {
                return View(model);
            }

            var connectionString = _context.Database.GetConnectionString();

            int id = conf.PARM_ID;
            //Realizo la grabacion en IMAC  
           

            try
            {

                //Genero el lote de datos a usar

                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("dmComprobantes_Con_Saldo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdTarjeta", id);
                    cmd.Parameters.AddWithValue("@FechaDesde", model.Desde.Date);
                    cmd.Parameters.AddWithValue("@FechaHasta", model.Hasta.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al grabar IMAC: " + e.Message);
                }


                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("dmComprobantes_Con_Saldo_Grabacion_Imac", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdTarjeta", id));

                    conn.Open();
                    await cmd.ExecuteNonQueryAsync();
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al grabar IMAC: " + e.Message);
                }

                //Fin Grabacion IMAC

                var datosTxt = await _context.dmLOTE_COMPROBANTES.ToListAsync();
                //Genero el archivo txt con los datos de los recibos

                if (datosTxt.Count == 0) {  return View("Index"); }

                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    StreamWriter sw = new StreamWriter(memoryStream);                   

                    int contador = 0;
                    foreach (dmLOTE_COMPROBANTES elem in datosTxt)
                    {
                        if (contador == 0)
                        {
                            sw.WriteLine("0DEBLIQC 0021615711900000    " + model.Presentacion.Year + addCero(model.Presentacion.Month) + addCero(model.Presentacion.Day) + "1543" + "0                                                         *");
                        }

                        sw.WriteLine("1" + elem.LOTE_NRO_TARJ + "   " + Right(elem.LOTE_MAX_CVCL.ToString(), 8) +
                            model.Presentacion.Year + addCero(model.Presentacion.Month) + addCero(model.Presentacion.Day) +
                            "0005" + Right((elem.LOTE_SALDO_LOC * 100).ToString(), 15) + Right(elem.LOTE_MAX_CVCL.ToString(), 15)
                            + " " + "                            *"
                            );
                        contador++;
                        if (contador == 98) contador = 0;
                    }
                    //PIE DE TXT
                    sw.WriteLine("9DEBLIQC 0021615711900000    " + model.Presentacion.Year + addCero(model.Presentacion.Month) + addCero(model.Presentacion.Day) + "1543" +
                        Right(datosTxt.First().LOTE_CUOTAS_TOTAL.ToString(), 7) + Right(datosTxt.First().LOTE_IMPORTE_TOTAL.ToString(), 15) + "                                    *");
                    sw.Close();

                    return File(memoryStream.ToArray(), "text/plain", "VISA.txt");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al generar archivo txt: " + e.Message);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error inesperado: " + e.Message);
            }
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //cantidadRelleno es el largo total que va a tener el string resultante.
        public string Right(string texto, int cantidadRelleno)
        {
            string result = "";
            for (int i = 0; i < cantidadRelleno; i++)
            {
                result += "0";
            }
            result += texto;
            return result.Substring(texto.Length);
        }

        public string addCero(int dato)
        {
            var text = dato.ToString();
            if (dato < 10)
            {
                text = "0" + text;
            }
            return text;
        }
    }
}




