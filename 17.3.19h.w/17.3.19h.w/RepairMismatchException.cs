using System;
using System.Runtime.Serialization;

namespace _17._3._19h.w
{
    [Serializable]
    public class RepairMismatchException :ApplicationException 
    {
        public RepairMismatchException()
        {
        }

        public RepairMismatchException(string message) : base(message)
        {
        }

        public RepairMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}