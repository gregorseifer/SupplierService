using System;
using Grpc.Core;

namespace Suppliers {
    [System.Serializable]
    public class UnknownSupplierException : RpcException
    {
        public UnknownSupplierException(Status status) : base(status)
        {
        }
    }
}