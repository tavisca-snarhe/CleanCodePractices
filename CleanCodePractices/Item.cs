using System;

namespace CleanCodePractices
{
    public class Item
    {
        public IProduct _product { get; private set; }
        public Guid ItemId { get; private set; }
        public Guid CartId { get; private set; }
        public int Quantity { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateUpdated { get; private set; }
        public double TotalPrice { get; private set; }
        public double TotalDiscount { get; private set; }

        public Item(IProduct product, Guid cartId)
        {
            _product = product;
            ItemId = Guid.NewGuid();
            CartId = cartId;
            Quantity = 1;
            TotalPrice = product.Price;
            TotalDiscount = 0;
            DateCreated = DateUpdated = new DateTime();
        }

        public Item(IProduct product, Guid cartId, double discount)
        {
            _product = product;
            ItemId = Guid.NewGuid();
            CartId = cartId;
            Quantity = 1;
            TotalPrice = product.Price;
            TotalDiscount = discount;
            DateCreated = DateUpdated = new DateTime();
        }

        public Guid GetItemId()
        {
            return ItemId;
        }

        public void IncreaseQuantity(int value)
        {
            Quantity += value;
            TotalPrice += _product.Price * value;

            // TotalDiscount = ;   
            DateUpdated = new DateTime();
        }
    }
}