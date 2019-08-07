using System;
using System.Runtime.Serialization;

namespace CleanCodePractices
{
    [Serializable]
    internal class NegativePercentageException : Exception
    {
        public NegativePercentageException()
        {
        }

        public NegativePercentageException(string message) : base(message)
        {
            Console.WriteLine("Percentage cannot be a negative number.");
        }

        public NegativePercentageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativePercentageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}