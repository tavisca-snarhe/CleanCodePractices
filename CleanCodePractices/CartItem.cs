namespace CleanCodePractices
{
    public class CartItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public CartItem(Product product, int quantity)
        {
            if (quantity < 0)
                throw new NegativeQuantityException();
            Product = product;
            Quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return (Product.Price * Quantity);
        }
    }
}