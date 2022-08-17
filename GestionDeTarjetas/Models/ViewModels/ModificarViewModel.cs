namespace GestionDeTarjetas.Models.ViewModels
{
    public class ModificarViewModel
    {

        public List<TipoRecibo> Recibos { get; set; }

        public List<TipoFactura> Facturas { get; set; }

        public List<Cobrador> Cobradores { get; set; }

        public List<CuentaCte> Cuentas { get; set; }

        public List<string> FacturasSeleccionadas { get; set; }

        public List<string> RecibosSeleccionados { get; set; }
        public List<string> CobradoresSeleccionados  { get; set; }
        public List<int> CuentasSeleccionadas    { get; set; }
                                                  
    public ModificarViewModel(List<TipoRecibo> recibos, List<TipoFactura> facturas,
                                    List<Cobrador> cobradores, List<CuentaCte> cuentas, 
                                    List<string> recibosSeleccionados,List<string> facturasSeleccionadas,
                                    List<string> cobradoresSeleccionados, List<int> cuentasSeleccionadas)
        {
            Recibos = recibos;
            Facturas = facturas;
            Cobradores = cobradores;
            Cuentas = cuentas;
            FacturasSeleccionadas = facturasSeleccionadas;
            RecibosSeleccionados = recibosSeleccionados;
            CobradoresSeleccionados = cobradoresSeleccionados;
            CuentasSeleccionadas = cuentasSeleccionadas;
        }
    }
}
