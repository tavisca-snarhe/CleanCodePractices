using System.Collections.Generic;
using System.Linq;

namespace CleanCodePractices
{
    public class Cart
    {
        private List<CartItem> _cartItems;
        public double DiscountPercentage;
        public string DiscountType;

        public Cart()
        {
            DiscountPercentage = 0;
            DiscountType = "FIXED";
            _cartItems = new List<CartItem>();
        }

        public Cart(int discountPercentage)
        {
            if (discountPercentage < 0)
                throw new NegativePercentageException();

            DiscountPercentage = discountPercentage;
            DiscountType = "FIXED";
            _cartItems = new List<CartItem>();
        }

        public Cart(string discountType)
        {
            switch (discountType)
            {
                case "CONFIG":
                    DiscountType = "CONFIG";
                    break;

                case "CATEGORYWISE":
                    DiscountType = "CATEGORYWISE";
                    break;

                default:
                    throw new UnknownDiscountCategoryException();
            }
            _cartItems = new List<CartItem>();
        }

        public void SetDiscountPercentage(double discountPercentage)
        {
            if (discountPercentage < 0)
                throw new NegativePercentageException();

            DiscountPercentage = discountPercentage;
            DiscountType = "FIXED";
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
            double DiscountedPrice  = 0;
            double ProductsTotalPrice = GetTotalPrice();

            switch (DiscountType)
            {
                case "FIXED":
                    DiscountedPrice = ProductsTotalPrice - (ProductsTotalPrice * DiscountPercentage / 100);
                    break;

                case "CATEGORYWISE":
                    for(int i = 0; i < _cartItems.Count; i++)
                    {
                        DiscountedPrice += _cartItems[i].GetDiscountedPrice();
                    }
                    break;

                case "CONFIG":
                    DiscountedPrice = ProductsTotalPrice - (ProductsTotalPrice * AppConfigs.DiscountPercentage / 100);
                    break;

                default:
                    throw new UnknownDiscountCategoryException();
            }

            return DiscountedPrice;
        }
    }
}
