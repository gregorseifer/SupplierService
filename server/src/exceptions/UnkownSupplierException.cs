using System;
using Grpc.Core;

namespace Suppliers {
    [System.Serializable]
    public class UnknownSupplierException : RpcException
    {
        public UnknownSupplierException() 
            : base( new Status(StatusCode.InvalidArgument, "Der Lieferant existiert leider nicht") ){}   
    }
}