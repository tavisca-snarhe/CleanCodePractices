using System;

namespace CleanCodePractices
{
    public interface IProduct
    {
        string Name { get; set; }
        Guid Id { get; set; }
        double Price { get; set; }
    }
}
