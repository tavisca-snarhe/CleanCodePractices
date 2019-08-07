using CleanCodePractices;
using System.Collections.Generic;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class CartFixtures
    {
        Cart MyCart;

        [Fact]
        public void Should_Be_Able_To_Add_Items_In_Cart()
        {
            MyCart = new Cart();
            MyCart.AddItem(new Product("Potato", 200), 5);

            List<CartItem> expectedList = new List<CartItem>();
            expectedList.Add(new CartItem(new Product("Potato", 200), 5));

            Assert.Equal(expectedList.ToString(), MyCart.GetItems().ToString());
        }

        [Fact]
        public void Get_Total_Price_Should_Return_Correct_Price()
        {
            MyCart = new Cart();
            MyCart.AddItem(new Product("Potato", 200), 9);
            MyCart.AddItem(new Product("Tomato", 100), 1);

            Assert.Equal(1900, MyCart.GetTotalPrice());
        }

        [Fact]
        public void Get_Discounted_Price_Should_Return_Correct_Price()
        {
            MyCart = new Cart();
            MyCart.AddItem(new Product("Potato", 200), 9);
            MyCart.AddItem(new Product("Tomato", 100), 2);
            MyCart.SetDiscountPercentage(10);

            Assert.Equal(1800, MyCart.GetDiscountedPrice());
        }

        [Fact]
        public void Get_Discounted_Price_Should_Return_Correct_Price_When_Discount_Not_Set()
        {
            MyCart = new Cart();
            MyCart.AddItem(new Product("Potato", 200), 9);
            MyCart.AddItem(new Product("Tomato", 100), 2);

            Assert.Equal(2000, MyCart.GetDiscountedPrice());
        }

    }
}