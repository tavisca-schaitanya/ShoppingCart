namespace ShoppingCart
{
    public class Shirt : Product
    {
        public override string ProductName { get; set; } = "shirt";
        public override double ProductPrice { get; set; } = 1599.0;
        public override double Discount { get; set; } = 0;
    }
}
