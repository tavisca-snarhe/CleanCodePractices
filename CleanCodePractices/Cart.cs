using System;
using System.Collections.Generic;

namespace CleanCodePractices
{
    public class Cart
    {
        public Guid Id { get; private set; }
        List<Item> _items;
        public DateTime DateCreated { get; private set; }
        public DateTime DateUpdated { get; private set; }
        public double TotalDiscount { get; private set; }
        public double TotalPrice { get; private set; }
        public double TotalDiscountedPrice { get; private set; }

        public Cart()
        {
            Id = Guid.NewGuid();
            _items = new List<Item>();
            DateCreated = DateUpdated = new DateTime();
            TotalDiscount = TotalDiscountedPrice = TotalPrice = 0;
        }

        public List<Item> GetCartItems()
        {
            return _items;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
            TotalPrice += item.TotalPrice;
            TotalDiscount += item.TotalDiscount;
            TotalDiscountedPrice = TotalPrice - TotalDiscount;
            DateUpdated = new DateTime();
        }

        public void RemoveItem(Guid itemId)
        {
            Item itemToRemove = null;
            foreach(Item item in _items)
            {
                itemToRemove = item.ItemId == itemId ? item : null;
                if (itemToRemove != null)
                {
                    _items.Remove(itemToRemove);
                    TotalPrice -= item.TotalPrice;
                    TotalDiscount -= item.TotalDiscount;
                    TotalDiscountedPrice = TotalPrice - TotalDiscount;
                    DateUpdated = new DateTime();
                    return;
                }
            }
        }
    }
}