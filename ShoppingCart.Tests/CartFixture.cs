using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ShoppingCart.Tests
{
    public class CartFixture
    {
        [Fact]
        public void Empty_Cart_Should_Have_Zero_Total()
        {
            Cart cart = new Cart();
            Assert.Equal(0, cart.GetTotalCartPrice());
        }


        [Fact]
        public void Can_Add_Products_To_Cart()
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            var expectedItems = new List<CartItem>() { cartItem };
            Assert.Equal(expectedItems, cart.GetCartItems());
        }


        [Fact]
        public void Cart_Can_Increase_Quantity_On_Add()
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            CartItem cartItem2 = new CartItem(shirt, 1);
            cart.AddItem(cartItem2);
            int expectedQuantity = 4;
            Assert.Equal(expectedQuantity, cart.GetCartItems().First().quantity);
        }


        [Fact]
        public void Can_Remove_Item_From_cart()
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            cart.RemoveItem("shirt", 3);
            Assert.Empty(cart.GetCartItems());
        }

        [Fact]
        public void Cart_Can_Calculate_Total_Price()
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            Jean jean = new Jean();
            CartItem cartItem2 = new CartItem(jean, 2);
            cart.AddItem(cartItem2);
            var expectedCartPrice = 9995.0;
            Assert.Equal(expectedCartPrice, cart.GetTotalCartPrice());
        }

        [Fact]
        public void Cart_Can_Calculate_Discounted_Price()
        {
            Cart cart = new Cart();
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cart.AddItem(cartItem);
            Jean jean = new Jean();
            CartItem cartItem2 = new CartItem(jean, 2);
            cart.AddItem(cartItem2);
            cart.SetDiscount(10);
            var expectedCartPrice = 8995.5;
            Assert.Equal(expectedCartPrice, cart.GetTotalCartPrice());
        }
    }
}
