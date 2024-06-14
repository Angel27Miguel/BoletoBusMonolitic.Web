using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class FacturaDb : IFactura
    {
        private readonly BoletoBusContext context;
        public void ActualizarFactura(FacturaUpdateModel facturaUpdate)
        {
            Factura FacturaUptade = this.context.Factura.Find(facturaUpdate.IDFactura);

            FacturaUptade.IDFactura = facturaUpdate.IDFactura;
            FacturaUptade.IDPedido = facturaUpdate.IDPedido;
            FacturaUptade.Total = facturaUpdate.Total;

            this.context.Factura.Update(FacturaUptade);
            this.context.SaveChanges();
        }

        public void EliminarFactura(FacturaDeleteModel facturaDelete)
        {
            var Facturaeliminarmodel = this.context.Factura.Find(facturaDelete.IdFactura);
            if (facturaDelete == null)
            {

            }

            Facturaeliminarmodel.IDFactura = facturaDelete.IdFactura;

            this.context.Remove(Facturaeliminarmodel);
            this.context.SaveChanges();
        }

        public Factura GetFactura(int IDFactura)
        {
            var Factura = this.context.Factura.Find(IDFactura);
            FacturaModel facturaModel = new FacturaModel()
            {
                IDFactura= Factura.IDFactura,
                IDPedido= Factura.IDPedido,
                Total=Factura.Total,    
                Fecha=Factura.Fecha,
            };

            return Factura;

         }

        public List<FacturaModel> GetFactura()
        {
            return this.context.Factura.Select(Factura => new FacturaModel()
            {
                IDFactura = Factura.IDFactura,
                IDPedido = Factura.IDPedido,
                Total = Factura.Total,
                Fecha = Factura.Fecha,

            }).ToList();
        }

        public void GuardarFactura(FacturaSaveModel facturaSave)
        {
            {
               Factura factura= new Factura()
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

       
}