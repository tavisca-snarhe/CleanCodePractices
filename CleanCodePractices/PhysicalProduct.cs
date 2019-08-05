using System;

namespace CleanCodePractices
{
    public class PhysicalProduct : IProduct
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public double Price { get; set; }
        public Dimension Dimension { get; set; }

        public PhysicalProduct()
        {
            Id = Guid.NewGuid();
            Price = 0;
        }
    }
}
