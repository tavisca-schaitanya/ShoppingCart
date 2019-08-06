using System;
using Xunit;

namespace ShoppingCart.Tests
{
    public class CartItemFixture
    {
        [Fact]
        public void Initial_Quantity_Should_Be_1_For_Item()
        {
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt);
            Assert.Equal(1, cartItem.quantity);
        }


        [Fact]
        public void CartItem_Should_calculate_Total_Price()
        {
            Shirt shirt = new Shirt();
            CartItem cartItem = new CartItem(shirt, 3);
            cartItem.CalculateCartItemTotalPrice();
            Assert.Equal(4797, cartItem.totalPrice);
        }
    }
}