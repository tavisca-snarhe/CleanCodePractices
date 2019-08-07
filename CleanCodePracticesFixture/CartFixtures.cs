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
            Vegetable vegetable = new Vegetable(10);
            Product potato = new Product("Potato", 100, vegetable);

            MyCart.AddItem(potato, 4);

            List<CartItem> expectedList = new List<CartItem>();
            expectedList.Add(new CartItem(potato, 4));

            Assert.Equal(expectedList.ToString(), MyCart.GetItems().ToString());
        }

        [Fact]
        public void Get_Total_Price_Should_Return_Correct_Price()
        {
            MyCart = new Cart();
            Vegetable vegetable = new Vegetable(0);
            Dairy dairy = new Dairy(0);
            Product potato = new Product("Potato", 100, vegetable);
            Product milk = new Product("Milk", 10, dairy);

            MyCart.AddItem(potato, 9);
            MyCart.AddItem(milk, 10);

            Assert.Equal(1000, MyCart.GetTotalPrice());
        }

        [Fact]
        public void Get_Discounted_Price_Should_Return_Correct_Price()
        {
            MyCart = new Cart();
            Vegetable vegetable = new Vegetable(0);
            Dairy dairy = new Dairy(0);
            Product potato = new Product("Potato", 100, vegetable);
            Product milk = new Product("Milk", 10, dairy);

            MyCart.AddItem(potato, 9);
            MyCart.AddItem(milk, 10);
            MyCart.SetDiscountPercentage(10);

            Assert.Equal(900, MyCart.GetDiscountedPrice());
        }

        [Fact]
        public void Get_Discounted_Price_Should_Return_Correct_Price_When_Discount_Not_Set()
        {
            MyCart = new Cart();
            Vegetable vegetable = new Vegetable(0);
            Product potato = new Product("Potato", 100, vegetable);
            MyCart.AddItem(potato, 9);
            
            Assert.Equal(900, MyCart.GetDiscountedPrice());
        }

    }
}