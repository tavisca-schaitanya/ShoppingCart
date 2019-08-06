using System;
using System.Linq;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            cart.GetTotalCartPrice();
        }
    }
}
