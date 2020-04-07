using System;
using System.Collections.Generic;

namespace Suppliers {
    class TestData {
        public static List<Product> createTestProductList() {
            List<Product> products = new List<Product>();
            Product p1 = new Product {
                Id = "0000001",
                Name = "Alpha",
                SupplierFk = "0000001"
            };
            products.Add(p1);
            Product p2 = new Product {
                Id = "0000002",
                Name = "Beta"

            };
            products.Add(p2);
            Product p3 = new Product {
                Id = "0000003",
                Name = "Delta"
            };
            products.Add(p3);
            Product p4 = new Product {
                Id = "0000004",
                Name = "Epsilon"
            };
            products.Add(p4);
            Product p5 = new Product {
                Id = "0000005",
                Name = "Teta"
            };
            products.Add(p5);
            Product p6 = new Product {
                Id = "0000006",
                Name = "Zeta"
            };
            products.Add(p6);
            return products;
        }
        
        public static List<Supplier> createTestSupplierList() {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier p1 = new Supplier {
                Id = "0000001",
                Name = "Alpha",
                Phone = "01763267"
            };
            suppliers.Add(p1);
            Supplier p2 = new Supplier {
                Id = "0000002",
                Name = "Beta",
                Phone = "01763267"
            };
            suppliers.Add(p2);
            Supplier p3 = new Supplier {
                Id = "0000003",
                Name = "Delta",
                Phone = "01763267"
            };
            suppliers.Add(p3);
            Supplier p4 = new Supplier {
                Id = "0000004",
                Name = "Epsilon",
                Phone = "01763267"
            };
            suppliers.Add(p4);
            Supplier p5 = new Supplier {
                Id = "0000005",
                Name = "Teta",
                Phone = "01763267"
            };
            suppliers.Add(p5);
            Supplier p6 = new Supplier {
                Id = "0000006",
                Name = "Zeta",
                Phone = "01763267"
            };
            suppliers.Add(p6);
            return suppliers;
        }
    }
}