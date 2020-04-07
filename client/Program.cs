using Grpc.Core;
using System;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                var client = new SupplierService.SupplierServiceClient(channel);

                Console.WriteLine("Funktionen testen:");

                
                FindAllPreferredSuppliersResponse suppList = client.findAllPreferredSuppliers(new FindAllPreferredSuppliersRequest());
                Console.WriteLine("\nAlle präferierten Lieferanten finden [findAllPreferredSuppliers]:");
                foreach (Supplier supp in suppList.Suppliers) {
                    Console.WriteLine($"Id: {supp.Id} - Name: {supp.Name} - Telefon: {supp.Phone}");
                }

                Product product = new Product {
                    Id = "0000003"
                };
                Supplier supplier = new Supplier {
                    Id = "0000004"
                };
                Console.WriteLine($"\nLieferant {supplier.Id} als Präferenz für Produkt {product.Id} einstellen [setPreferredSupplierForProduct]");
                SetPreferredSupplierForProductRequest request = new SetPreferredSupplierForProductRequest {
                    Supplier = supplier,
                    Product = product
                };
                client.setPreferredSupplierForProduct(request);

                Console.WriteLine("\nNochmal alle präferierten Lieferanten finden [findAllPreferredSuppliers]:");
                suppList = client.findAllPreferredSuppliers(new FindAllPreferredSuppliersRequest());
                foreach (Supplier supp in suppList.Suppliers) {
                    Console.WriteLine($"Id: {supp.Id} - Name: {supp.Name} - Telefon: {supp.Phone}");
                }
                
                Console.WriteLine($"\nDen präferierten Lieferanten zu Produkt {product.Id} finden [findPreferredSupplier]:");
                FindPreferredSupplierRequest request2 = new FindPreferredSupplierRequest {
                    Product = product
                };
                FindPreferredSupplierResponse response = client.findPreferredSupplier(request2);
                Console.WriteLine(response.Supplier?.Id);

                Console.WriteLine("\nEinen Lieferanten als Präferenz für ein nicht existierendes Produkt setzen, um eine UnknownProductException zu werfen:");
                Product product2 = new Product {
                    Id = "0000000000"
                };
                SetPreferredSupplierForProductRequest request3 = new SetPreferredSupplierForProductRequest {
                    Supplier = supplier,
                    Product = product2
                };
                client.setPreferredSupplierForProduct(request3);

                channel.ShutdownAsync().Wait();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (RpcException rex) {
                Console.WriteLine($"Exception encountered: StatusCode - {rex.Status.StatusCode} [{rex.Message}]");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}