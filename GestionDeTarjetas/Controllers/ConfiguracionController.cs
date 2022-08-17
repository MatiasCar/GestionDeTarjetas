using GestionDeTarjetas.Models;
using GestionDeTarjetas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionDeTarjetas.Controllers
{
    public class ConfiguracionController : Controller
    {

        private readonly ContextDB _context;

        public ConfiguracionController(ContextDB context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View();
        }

      
        // GET
        public async Task<IActionResult> GuardarVisa()
        {
            var tccb = _context.CCOB_TCCB;
            var rec = _context.CCOB_TCBR;
            //var fac = _context.DMED_TARJ.Select(e => e.TARJ_TIPO_COMP).Distinct();
            var fac = await _context.CCOB_TCBV.Where(t => t.TCBV_ES_FCNDNC == "2" || t.TCBV_ES_FCNDNC == "1").Select(e => e.TCBV_TIPO_VAR).ToListAsync();

            var joinedRec = rec.Join(tccb,
                recKey => recKey.TCBR_TIPO_REC,
                tccbKey => tccbKey.TCCB_TIPO_COM,
                (recKey, tccbKey) =>
                  recKey.TCBR_TIPO_REC + "-" + tccbKey.TCCB_NOMBRE
                ).ToList();
            
            var joinedFac = fac.Join(tccb,
                facKey => facKey,
                tccbKey => tccbKey.TCCB_TIPO_COM,
                (facKey, tccbKey) =>
                  facKey + "-" + tccbKey.TCCB_NOMBRE
                ).ToList();
            
            var cobrador = await _context.SIST_COBR.Select(e => e.COBR_COBRADOR+'-'+e.COBR_NOMBRE).Distinct().ToListAsync();
            var cuentas = await _context.CONT_CUEN.Where(e=> e.CUEN_IMP_CCOBRAR == 1 & e.CUEN_UTILIZABLE ==1 && e.CUEN_USA_REFER != 1 && e.CUEN_USA_REFER != 0).Select(e => e.CUEN_CUENTA+"-"+e.CUEN_NOMBRE).ToListAsync();

            //var cuentas = _context.DMED_TARJ.Select(e => e.TARJ_CUENTA).Distinct();

            //var joinedCta = cuentas.Join(_context.CONT_CUEN,
            //    cuenKey => cuenKey,
            //    conKey => conKey.CUEN_CUENTA,
            //    (cuenKey, conKey) =>
            //    cuenKey + '-' + conKey.CUEN_NOMBRE
            //    ).ToList();

            var utilizable = _context.DMPARM_CONF.Where(e=> e.PARM_ID ==1).Select(e => e.PARM_UTILIZABLE==1? true : false).First();
            var view = new ConfigViewModel(joinedFac, joinedRec, cuentas ,cobrador, utilizable);
            return View(view);
        }

        [HttpPost]
        public IActionResult GuardarVisa(ConfigViewModel viewModel)
        {
            try
            {
                var parametro = _context.DMPARM_CONF.Where(e => e.PARM_NOMBRE == "VISA").Select(e => new  Parametro(e.PARM_ID,e.PARM_NOMBRE)).First();

                //Borro de la tabla a medida la cta que haya
                var ctaBorrar = _context.DMCTA_CONT.Where(e => e.CONT_PARM_ID == 1).ToList();
                if (ctaBorrar.Count() > 0) { _context.DMCTA_CONT.Remove(ctaBorrar.First()); };

                //Borro de la tabla a medida el recibo que haya
                var reciBorrar = _context.DMTIPO_RECI.Where(e => e.RECI_PARM_ID == 1).ToList();
                if (reciBorrar.Count() > 0) { _context.DMTIPO_RECI.Remove(reciBorrar.First()); } ;


                //Borro de la tabla a medida de facturas lo que haya 
                var factBorrar = _context.DMTIPO_FACT.Where(e => e.FACT_PARM_ID == 1).ToList();
                if (factBorrar.Count() > 0) { _context.DMTIPO_FACT.RemoveRange(factBorrar); } ;

                //Borro de la tabla a medida de cobrador lo que haya
                var cobrBorrar = _context.DMCOBRADOR.Where(e => e.COBR_PARM_ID == 1).ToList();
                if (cobrBorrar.Count() > 0) { _context.DMCOBRADOR.Remove(cobrBorrar.First()); } ;

                //Hago update de utilizable
                var newConfig = new DMPARM_CONF() { PARM_ID = parametro.Id, PARM_NOMBRE = parametro.NombreTarjeta, PARM_UTILIZABLE = viewModel.Utilizable == true ? Convert.ToInt16(1) : Convert.ToInt16(0)};
                _context.DMPARM_CONF.Update(newConfig);
                _context.SaveChanges();

                //Agrego la cta contable a la tabla a medida
                DMCTA_CONT cta = new DMCTA_CONT() { CONT_PARM_ID = 1, CONT_CTA = viewModel.CtaContable.First().Substring(0, viewModel.CtaContable.First().IndexOf("-")) };
                _context.DMCTA_CONT.Add(cta);
                _context.SaveChanges();

                //Agrego el tipo de recibo a la tabla a medida
                DMTIPO_RECI reci = new DMTIPO_RECI() { RECI_PARM_ID = 1, RECI_TIPO_RECI = viewModel.TipoRec.First().Substring(0, viewModel.TipoRec.First().IndexOf("-")) };
                _context.DMTIPO_RECI.Add(reci);
                _context.SaveChanges();

                //Agrego los tipos de factura a la tabla a medida
                DMTIPO_FACT fact = new DMTIPO_FACT();
                _context.DMTIPO_FACT.AddRange(viewModel.TipoFact.Select(e => new DMTIPO_FACT() { FACT_PARM_ID = 1, FACT_TIPO_FACT = e.Substring(0, e.IndexOf("-") ) }));
                _context.SaveChanges();
                ////Agrego el cobrador a la tabla a medida
                DMCOBRADOR cobr = new DMCOBRADOR() { COBR_PARM_ID = 1, COBR_COBRADOR = viewModel.Cobrador.First().Substring(0, viewModel.Cobrador.First().IndexOf("-")) };
                _context.DMCOBRADOR.Add(cobr);
                _context.SaveChanges();

                //Substring(0,textoACambiar.IndexOf("-")-1)
               // _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
            return View(viewModel);
        }
    }
}
