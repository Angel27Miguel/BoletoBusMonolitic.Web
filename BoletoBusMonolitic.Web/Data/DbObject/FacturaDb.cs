using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class FacturaDb : IFactura
    {
        private readonly BoletoBusContext context;

        public FacturaDb(BoletoBusContext context)
        {
            this.context = context;
        }
        

        public void ActualizarFactura(FacturaUpdateModel facturaUpdate)
        {
            Factura FacturaUptade = this.context.Factura.Find(facturaUpdate.IDFactura);

            FacturaUptade.IDFactura = facturaUpdate.IDFactura;
            FacturaUptade.IDPedido = facturaUpdate.IDPedido;
            FacturaUptade.Total = facturaUpdate.Total;

            this.context.Factura.Update(FacturaUptade);
            this.context.SaveChanges();
        }

        public void EliminarFactura()
        {
            
        }

        

        public List<FacturaModel> GetFacturaModel()
        {
            return this.context.Factura.Select(Factura => new FacturaModel()
            {
                IDFactura = Factura.IDFactura,
                IDPedido = Factura.IDPedido,
                Total = Factura.Total,
                Fecha = Factura.Fecha,

            }).ToList();
        }

        public FacturaModel GetFactura(int IdFactura)
        {

            var Factura = this.context.Factura.Find(IdFactura);

            FacturaModel facturaModel = new FacturaModel()
            {
                IDFactura = Factura.IDFactura,
                IDPedido = Factura.IDPedido,
                Total = Factura.Total,
                Fecha = Factura.Fecha,
            };

            return facturaModel ;

        }

   
        public void GuardarFactura(FacturaSaveModel facturaSave)
        {
            Factura factura = new Factura()
            {
                IDFactura = facturaSave.IDFactura,
                IDPedido = facturaSave.IDPedido,
                Total = facturaSave.Total,
                Fecha = facturaSave.Fecha

            };
            this.context.Factura.Add(factura);
            this.context.SaveChanges();
        }
    }

       
}