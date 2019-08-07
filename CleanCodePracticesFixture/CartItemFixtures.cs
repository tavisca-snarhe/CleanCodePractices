using CleanCodePractices;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class CartItemFixtures
    {
        [Fact]
        public void Constructor_Should_Throw_Exception_If_Negative_Quantity_Passed()
        {
            Vegetable vegetable = new Vegetable(0);
            Product potato = new Product("Potato", 100, vegetable);

            Assert.Throws<NegativeQuantityException>(() => new CartItem(potato, -19));
        }

        [Fact]
        public void Total_Price_Should_Be_Sumation_Of_All_Products_Price()
        {
            Vegetable vegetable = new Vegetable(10);
            Product potato = new Product("Potato", 100, vegetable);
            CartItem item = new CartItem(potato, 10);

            Assert.Equal(1000, item.GetTotalPrice());
        }

        [Fact]
        public void Total_Discounted_Price_Should_Be_Sumation_Of_All_Products_Discounted_Price()
        {
            Vegetable vegetable = new Vegetable(10);
            Product potato = new Product("Potato", 100, vegetable);
            CartItem item = new CartItem(potato, 10);

            Assert.Equal(900, item.GetDiscountedPrice());
        }
    }
}