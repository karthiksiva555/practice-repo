namespace NHibernateSuccintlyDemo.Models
{
    public class ShoppingPoints
    {
        public virtual int ShopperId { get; set; }
        public virtual double Points { get; set; }
        public virtual Shopper Shopper { get; set; }
    }
}