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
        
        public PhysicalProduct(string name, double price, Dimension dimension)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Dimension = dimension;
        }
    }
}
