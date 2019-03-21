using System;
using System.Runtime.Serialization;

namespace _17._3._19h.w
{
    [Serializable]
    public class WeNotFixTotalLostException : ApplicationException
    {
        public WeNotFixTotalLostException()
        {
        }

        public WeNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}