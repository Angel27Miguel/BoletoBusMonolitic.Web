namespace BoletoBusMonolitic.Web.Data.Core
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? UserMod { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
