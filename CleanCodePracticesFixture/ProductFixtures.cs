using CleanCodePractices;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class ProductFixtures
    { 
        [Fact]
        public void Constructor_Should_Throw_Exception_If_Negative_Price_Passed()
        {
            Vegetable vegetable = new Vegetable(10);

            Assert.Throws<NegativePriceException>(() => new Product("Potato", -10, vegetable));
        }

        [Fact]
        public void Get_Discounted_Price_Sould_Return_Correct_Price()
        {
            Vegetable vegetable = new Vegetable(10);
            Product potato = new Product("Potato", 100, vegetable);

            Assert.Equal(90, potato.GetDiscountedPrice());
        }
    }
}