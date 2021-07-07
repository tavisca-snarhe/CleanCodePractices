namespace CleanCodePractices
{
    public class Clothing : ICategory
    {
        public double DiscountPercentage { get; private set; }

        public Clothing(double discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        void SetDiscountPercentage(double discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }
    }
}