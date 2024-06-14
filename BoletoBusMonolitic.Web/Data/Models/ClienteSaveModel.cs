namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ClienteSaveModel
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }


    }
}
