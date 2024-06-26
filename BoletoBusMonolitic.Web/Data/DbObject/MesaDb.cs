using BoletoBusMonolitic.Web.Data.Context;

using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class MesaDb : IMesa

    { 
       private readonly BoletoBusContext context;


        public MesaDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public void EliminarMesa(MesaDeleteModel mesaDelete)
        {
           
        }


        public void GuardarMesa(MesaSaveModel mesaSave)
        {
            Mesa mesa = new Mesa()
            {
               IDMesa= mesaSave.IDMesa, 
               Capacidad= mesaSave.Capacidad,   
               Estado=  mesaSave.Estado,

            };
            this.context.Mesa.Add(mesa);
            this.context.SaveChanges();
        }

        public void UpdateMesa(MesaUpdateModel mesaUpdate)
        {
            Mesa MesaUptade = this.context.Mesa.Find(mesaUpdate.IDMesa);

            MesaUptade.IDMesa = mesaUpdate.IDMesa;
            MesaUptade.Estado = mesaUpdate.Estado;
            MesaUptade.Capacidad = mesaUpdate.Capacidad;
           

            this.context.Mesa.Update(MesaUptade);
            this.context.SaveChanges();
        }

        MesaModel IMesa.GetMesa(int IDMesa)
        {
            var Mesa = this.context.Mesa.Find(IDMesa);

            MesaModel mesaModel = new MesaModel()
            {
                IDMesa = Mesa.IDMesa,
                Capacidad = Mesa.Capacidad,
                Estado = Mesa.Estado,
            };

            return mesaModel;
        }

        List<MesaModel> IMesa.GetMesaModel()
        {
            return this.context.Mesa.Select(Mesa => new MesaModel()
            {
                IDMesa = Mesa.IDMesa,
                Capacidad = Mesa.Capacidad,
                Estado = Mesa.Estado,
            }).ToList();
        }
    }

      
    
}