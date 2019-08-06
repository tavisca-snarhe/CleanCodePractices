using CleanCodePractices;
using System.Collections.Generic;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class CartFixtures
    {
        Cart cart;
        [Fact]
        public void AddItem_Should_AddItem_In_Cart_And_Update_Values_Accordingly()
        {
            cart = new Cart();
            IProduct shoe = new PhysicalProduct("shoex1", 800.12, new Dimension(21, 40));
            Item shoeItem = new Item(shoe, cart.Id);
            cart.AddItem(shoeItem);
            List<Item> cartItems = new List<Item>();
            cartItems.Add(shoeItem);

            Assert.Equal(cartItems, cart.GetCartItems());
        }
    }
}