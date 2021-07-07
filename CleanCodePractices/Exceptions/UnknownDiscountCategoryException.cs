using System;
using System.Runtime.Serialization;

namespace CleanCodePractices
{
    [Serializable]
    internal class UnknownDiscountCategoryException : Exception
    {
        public UnknownDiscountCategoryException()
        {
        }

        public UnknownDiscountCategoryException(string message) : base(message)
        {
            Console.WriteLine("Unknown Discount Category bro.");
        }

        public UnknownDiscountCategoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownDiscountCategoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}