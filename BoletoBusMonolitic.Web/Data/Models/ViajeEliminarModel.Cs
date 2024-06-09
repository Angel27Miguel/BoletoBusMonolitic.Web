namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ViajeEliminarModel
    {
        public int ViajeId { get; set; }
        public int ViajeDelete { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
