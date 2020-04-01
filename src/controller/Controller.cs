using System;
using System.Threading.Tasks;
using Grpc.Core;
namespace Suppliers
{
    class SupplierImpl: global::SupplierService.SupplierServiceBase
    {
        SupplierService suppData;
        public SupplierImpl() {
            this.suppData = new SupplierService();
        }
        
        public override Task<SupplierList> findAllPreferredSuppliers(Empty request, ServerCallContext context)
        {
            return Task.FromResult( suppData.findAllPreferredSuppliers() );
        }
        public override Task<Supplier> findPreferredSupplier(Product product, ServerCallContext context)
        {
            return Task.FromResult( suppData.findPreferredSupplier(product) );
        }
        public override Task<Empty> setPreferredSupplierForProduct(SetSupplierParams setSupplierParams, ServerCallContext context)
        {
            return Task.FromResult( suppData.setPreferredSupplierForProduct(setSupplierParams) );
        }
    }
}