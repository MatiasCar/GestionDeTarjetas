using GestionDeTarjetas.Models;
using GestionDeTarjetas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDeTarjetas.Controllers
{
    public class ModificarController : Controller
    {
        private readonly ContextDB _context;

        public ModificarController(ContextDB context)
        {
            _context = context;
        }
        public async Task<IActionResult> ModificarVisa()
        {
            // datos de plataforma
            var recibos = await _context.CCOB_TCBR.Select(e => e.TCBR_TIPO_REC).Distinct().Select(e => new TipoRecibo(e)).ToListAsync();
            var facturas = await _context.CCOB_TCBV.Where(t => t.TCBV_ES_FCNDNC == "1").Select(e => new TipoFactura(e.TCBV_TIPO_VAR)).ToListAsync();
            var cobradores = await _context.CCOB_CLIE.Select(e => new Cobrador(e.CLIE_COBRADOR)).Distinct().ToListAsync();
            var ctascontables = await _context.CCOB_CTEC.Select(e => new CuentaCte(e.CTEC_CTACTE_CTEC)).ToListAsync();


            // datos de tablas a medida
            var rec = await _context.DMTIPO_RECI.Where(e => e.RECI_ID == 1).Select(e => e.RECI_TIPO_RECI).ToListAsync();
            var fac = await _context.DMTIPO_FACT.Where(e => e.FACT_ID == 1).Select(e => e.FACT_TIPO_FACT).ToListAsync();
            var cobrador = await _context.DMCOBRADOR.Where(e => e.COBR_ID == 1).Select(e => e.COBR_COBRADOR).ToListAsync(); ;
            var ctec = await _context.DMCTA_CONT.Where(e => e.CONT_ID == 1).Select(e => Int32.Parse(e.CONT_CTA)).ToListAsync(); ;

            var view = new ModificarViewModel(recibos, facturas, cobradores, ctascontables, rec, fac, cobrador, ctec );
            return View(view);

            
        }
    }
}
