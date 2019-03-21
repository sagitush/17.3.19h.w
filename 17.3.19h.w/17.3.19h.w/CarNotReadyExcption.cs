using System;
using System.Runtime.Serialization;

namespace _17._3._19h.w
{
    [Serializable]
    public class CarNotReadyExcption : ApplicationException
    {
        public CarNotReadyExcption()
        {
        }

        public CarNotReadyExcption(string message) : base(message)
        {
        }

        public CarNotReadyExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotReadyExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}