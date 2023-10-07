namespace Back.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public virtual string name{ get; set; }
        public virtual string id_product{ get; set; }
    }
}