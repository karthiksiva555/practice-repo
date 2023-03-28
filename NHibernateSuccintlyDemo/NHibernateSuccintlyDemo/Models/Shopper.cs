namespace NHibernateSuccintlyDemo.Models
{
    public class Shopper
    {
        public virtual int ShopperId { get; set; }
        public virtual string ShopperName { get; set; }
        public virtual ShoppingPoints ShoppingPoints { get; set; }
    }
}