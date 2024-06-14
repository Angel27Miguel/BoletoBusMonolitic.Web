namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ClienteUpdateModel
    {
        public int ClienteID { get; set; }
        public string? Nombre { get; set; }
        public int Telefono { get; set; }
        public string? Email { get; set; }

        public DateTime? ModifyDate { get; set; }
        public int UserMod { get; set; }
    }
}
