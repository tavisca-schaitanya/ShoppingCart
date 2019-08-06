namespace ShoppingCart
{
    public abstract class Product
    {
        public abstract string ProductName { get; set; }
        public abstract double ProductPrice { get; set; }

        public abstract double Discount { get; set; }
    }
}
