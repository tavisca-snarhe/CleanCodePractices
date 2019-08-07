namespace CleanCodePractices
{
    public class Product
    {
        public string Name;
        public double Price;
        public ICategory Category;

        public Product(string name, double price, ICategory category)
        {
            if (price < 0)
                throw new NegativePriceException();

            Name = name;
            Price = price;
            Category = category;
        }

        public double GetDiscountedPrice()
        {
            double DiscountedPrice;
            DiscountedPrice = Price - (Price * Category.DiscountPercentage/100);

            return DiscountedPrice;
        }
    }
}