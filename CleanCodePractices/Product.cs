namespace CleanCodePractices
{
    public class Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            if (price < 0)
                throw new NegativePriceException();
            Name = name;
            Price = price;
        }
    }
}