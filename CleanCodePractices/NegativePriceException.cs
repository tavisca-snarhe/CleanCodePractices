using System;
using System.Runtime.Serialization;

namespace CleanCodePractices
{
    [Serializable]
    internal class NegativePriceException : Exception
    {
        public NegativePriceException()
        {
        }

        public NegativePriceException(string message) : base(message)
        {
            Console.WriteLine("Price cannot be a negative number.");
        }

        public NegativePriceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativePriceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}