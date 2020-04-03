using System;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace Suppliers
{
    public class SupplierService
    {
        List<Supplier> supplierList;
        List<Product> productList;
        public SupplierService() {
            supplierList = TestData.createTestSupplierList();
            productList = TestData.createTestProductList();
        }
        public List<Supplier> findAllPreferredSuppliers()
        {
            List<Supplier> list = new List<Supplier>();
            List<string> supplierIds = productList.FindAll(product => product.SupplierFk != null)
                .Select(product => product.SupplierFk)
                .ToList();
            return supplierList.FindAll( supplier => supplierIds.Contains(supplier.Id) );
        }
        public  Supplier findPreferredSupplier(Product product) {
            var p_fk = productList.Find( (Product p) => product.Id == p.Id ).SupplierFk;
            return supplierList.Find( supplier => p_fk == supplier.Id );
        }
        public void setPreferredSupplierForProduct(Supplier supplier, Product product) {
            var pId = (product??throw new ArgumentNullException()).Id;
            var sId = (supplier??throw new ArgumentNullException()).Id;
            if (productList.FindAll((Product p) => p.Id == pId).Count == 0) {
                throw new UnknownProductException();
            }
            if (supplierList.FindAll((Supplier s) => s.Id == sId).Count == 0) {
                throw new UnknownSupplierException();
            }
            productList.Find( (Product p) => p.Id == pId ).SupplierFk = sId;
        }
    }
}