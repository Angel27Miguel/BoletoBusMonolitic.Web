namespace BoletoBusMonolitic.Web.Data.Core
{
    public abstract class BaseEntity
    {
        private int Id;

        public  BaseEntity(int id)
        {
            this.Id = id;
        }
    }
}
