namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ClienteDeleteModel
    {
        public int IdCliente { get; set; }
        public int ClienteDelete { get; set; }
        public DateOnly DeleteDate { get; set; }
        public bool Deleted { get; set; }

    }
}
