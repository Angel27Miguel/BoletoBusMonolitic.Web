namespace BoletoBusMonolitic.Web.Data.Models
{
    public class BusEditarModel
    {
        public int IdBus { get; set; } 

        public string NumeroPlaca { get; set; } 

        public string Nombre { get; set; } 

        public int CapacidadPiso1 { get; set; } 

        public int CapacidadPiso2 { get; set; } 

        

        public bool Disponible { get; set; } 
    }
}
