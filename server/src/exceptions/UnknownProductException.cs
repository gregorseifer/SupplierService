using System;
using Grpc.Core;

namespace Suppliers{
    [Serializable]
    public class UnknownProductException : RpcException
    {
        public UnknownProductException() 
            : base( new Status(StatusCode.InvalidArgument, "Das Produkt existiert leider nicht") ){}
    }
    
}