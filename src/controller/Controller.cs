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
        
        public override Task<FindAllPreferredSuppliersResponse> findAllPreferredSuppliers(FindAllPreferredSuppliersRequest request, ServerCallContext context)
        {
            FindAllPreferredSuppliersResponse response = new FindAllPreferredSuppliersResponse();
            response.Suppliers.AddRange(suppData.findAllPreferredSuppliers());
            return Task.FromResult ( response );
        }
        public override Task<FindPreferredSupplierResponse> findPreferredSupplier(FindPreferredSupplierRequest request, ServerCallContext context)
        {
            FindPreferredSupplierResponse response = new FindPreferredSupplierResponse();
            response.Supplier = suppData.findPreferredSupplier(request.Product);
            return Task.FromResult( response );
        }
        public override Task<SetPreferredSupplierForProductResponse> setPreferredSupplierForProduct(SetPreferredSupplierForProductRequest request, ServerCallContext context)
        {
            suppData.setPreferredSupplierForProduct(request.Supplier, request.Product);
            return Task.FromResult( new SetPreferredSupplierForProductResponse() );
        }
    }
}