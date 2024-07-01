namespace BoletoBusMonolitic.Web.Data.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { 
        this.FechaCreacion = DateTime.Now;

        }
        public DateTime FechaCreacion { get; set; }

    }
}
