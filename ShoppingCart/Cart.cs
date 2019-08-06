using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart
    {
        private List<CartItem> _cartItemsList = new List<CartItem>();
        private double discount = 0;

        public void SetDiscount(double discount)
        {
            this.discount = discount;
        }


        private CartItem GetCartItemByName(string name)
        {
            return _cartItemsList.Find(cartItem => cartItem.product.ProductName == name);
        }

        public void AddItem(CartItem item)
        {
            var cartItem = GetCartItemByName(item.product.ProductName);

            if (cartItem == null)
            {
                _cartItemsList.Add(item);
                item.CalculateCartItemTotalPrice();
            }
            else
            {
                cartItem.quantity += item.quantity;
                cartItem.CalculateCartItemTotalPrice();
            }
        }


        public bool RemoveItem(string name, int quantity = 1)
        {
            var cartItem = GetCartItemByName(name);

            if (cartItem == null)
            {
                return false;
            }
            else if (cartItem.quantity < quantity)
            {
                return false;    
            }
            else if(cartItem.quantity == quantity)
            {
                _cartItemsList.Remove(cartItem);
            }
            else
            {
                cartItem.quantity -= quantity;
                cartItem.CalculateCartItemTotalPrice();
            }
            return true;
        }


        public double GetTotalCartPrice()
        {
            double totalPrice = 0;
            foreach(var item in _cartItemsList)
            {
                totalPrice += item.totalPrice - item.totalPrice * item.product.Discount / 100;
            }
            totalPrice -= totalPrice * discount / 100;
            return totalPrice;
        }


        public List<CartItem> GetCartItems()
        {
            return _cartItemsList;
        }

    }
}
