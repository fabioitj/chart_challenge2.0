namespace Back.Domain.Entities
{
    public class Product : BaseEntity
    {
        public virtual string name{ get; set; }
        public virtual string id_category{ get; set; }
    }
}