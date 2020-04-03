using System;

namespace Suppliers{
    [Serializable]
    public class UnknownProductException : Exception
    {
        public UnknownProductException() { }
        public UnknownProductException(string message) : base(message) { }
        public UnknownProductException(string message, Exception inner) : base(message, inner) { }
        protected UnknownProductException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}