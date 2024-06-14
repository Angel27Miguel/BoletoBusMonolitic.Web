namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MesaUpdateModel
    {
        public int IDMesa { get; set; }
        public int Capacidad { get; set; }
        public string? Estado { get; set; }

        public DateTime? ModifyDate { get; set; }
        public int UserMod { get; set; }
    }
}
