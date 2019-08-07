using System;
using System.Runtime.Serialization;

namespace CleanCodePractices
{
    [Serializable]
    internal class NegativeQuantityException : Exception
    {
        public NegativeQuantityException()
        {
        }

        public NegativeQuantityException(string message) : base(message)
        {
            Console.WriteLine("Quantity cannot be a negative number.");
        }

        public NegativeQuantityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeQuantityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}