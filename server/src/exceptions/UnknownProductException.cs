using System;
using Grpc.Core;

namespace Suppliers{
    [Serializable]
    public class UnknownProductException : RpcException
    {
        public UnknownProductException(Status status) : base(status)
        {
        }
    }
    
}