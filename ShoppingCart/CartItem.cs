namespace ShoppingCart
{
    public class CartItem
    {
        public Product product;
        public int quantity;
        public double totalPrice;

        public CartItem(Product product, int quantity = 1)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public void CalculateCartItemTotalPrice()
        {
            totalPrice = quantity * product.ProductPrice;
        }
    }
}
