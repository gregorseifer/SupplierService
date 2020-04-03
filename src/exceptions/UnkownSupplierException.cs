using System;

namespace Suppliers {
    [System.Serializable]
    public class UnknownSupplierException : System.Exception
    {
        public UnknownSupplierException() { }
        public UnknownSupplierException(string message) : base(message) { }
        public UnknownSupplierException(string message, System.Exception inner) : base(message, inner) { }
        protected UnknownSupplierException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}