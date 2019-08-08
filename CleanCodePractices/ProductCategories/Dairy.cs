namespace CleanCodePractices
{
    public class Dairy : ICategory
    {
        public double DiscountPercentage { get; private set; }

        public Dairy(double discountPercentage)
        {
            if (discountPercentage < 0)
                throw new NegativePercentageException();
            DiscountPercentage = discountPercentage;
        }

        void SetDiscountPercentage(double discountPercentage)
        {
            if (discountPercentage < 0)
                throw new NegativePercentageException();
            DiscountPercentage = discountPercentage;
        }
    }
}