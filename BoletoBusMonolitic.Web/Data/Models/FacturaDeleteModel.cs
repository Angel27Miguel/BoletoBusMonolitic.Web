namespace BoletoBusMonolitic.Web.Data.Models
{
    public class FacturaDeleteModel
    {
        public int IdFactura { get; set; }
        public int FacturaDelete { get; set; }
        public DateOnly DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
