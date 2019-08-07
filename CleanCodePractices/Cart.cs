using System.Collections.Generic;
using System.Linq;

namespace CleanCodePractices
{
    public class Cart
    {
        private List<CartItem> _cartItems;
        public double DiscountPercentage;

        public Cart()
        {
            DiscountPercentage = 0;
            _cartItems = new List<CartItem>();
        }

        public void SetDiscountPercentage(double discountPercentage)
        {
            if (discountPercentage < 0)
                throw new NegativePercentageException();

            DiscountPercentage = discountPercentage;
        }

        public void AddItem(Product product, int quantity)
        {
            _cartItems.Add(new CartItem(product, quantity));
        }

        public List<CartItem> GetItems()
        {
            return _cartItems.Select(item => new CartItem(item.Product, item.Quantity)).ToList();
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            for(int i=0;i<_cartItems.Count;i++)
            {
                totalPrice += _cartItems[i].GetTotalPrice();
            }

            return totalPrice;
        }

        public double GetDiscountedPrice()
        {
            if(DiscountPercentage == 0)
                return GetTotalPrice();

            double totalPrice = GetTotalPrice();
            double discountedPrice = totalPrice - (totalPrice * (DiscountPercentage / 100));

            return discountedPrice;
        }
    }
}
