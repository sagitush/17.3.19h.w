using System;
using System.Runtime.Serialization;

namespace _17._3._19h.w
{
    [Serializable]
    public class CarNullException : ApplicationException
    {
        public CarNullException()
        {
        }

        public CarNullException(string message) : base(message)
        {
        }

        public CarNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}