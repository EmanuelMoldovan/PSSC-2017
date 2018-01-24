using System;
using System.Runtime.Serialization;

namespace PsscT2.ModelGeneric
{
    [Serializable]
    internal class NotFundsException : Exception
    {
        public NotFundsException()
        {
        }

        public NotFundsException(string message) : base(message)
        {
        }

        public NotFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}