namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MesaDeleteModel
    {
        public int IdMesa { get; set; }
        public int MesaDelete { get; set; }
        public DateOnly DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
