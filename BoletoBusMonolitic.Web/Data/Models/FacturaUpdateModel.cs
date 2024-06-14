namespace BoletoBusMonolitic.Web.Data.Models
{
    public class FacturaUpdateModel
    {
        public int IDFactura { get; set; }
        public int IDPedido { get; set; }
        public int Total { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int UserMod { get; set; }
    }
}
