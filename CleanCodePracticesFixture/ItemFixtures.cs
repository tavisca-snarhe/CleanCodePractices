using CleanCodePractices;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class ItemFixtures
    {
        Cart cart;
        Item CartItem;
        [Fact]
        public void Increase_Item_Quantity_Test()
        {
            IProduct shoe = new PhysicalProduct();
            cart = new Cart();
            CartItem = new Item(shoe, cart.Id);
            CartItem.IncreaseQuantity(2);

            Assert.Equal(3, CartItem.Quantity);
        }
    }
}