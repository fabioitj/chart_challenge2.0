namespace Back.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public virtual int value{ get; set; }
        public virtual int month{ get; set; }
        public virtual string id_brand{ get; set; }
    }
}