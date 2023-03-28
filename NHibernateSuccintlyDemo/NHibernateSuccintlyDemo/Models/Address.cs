namespace NHibernateSuccintlyDemo.Models
{
    public class Address
    {
        public virtual int AddressId { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string City { get; set; }
        public virtual Student Student { get; set; }
    }
}