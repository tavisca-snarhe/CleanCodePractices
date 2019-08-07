namespace CleanCodePractices
{
    public class Vegetable : ICategory
    {
        public double DiscountPercentage { get; private set; }

        public Vegetable(double discountPercentage)
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