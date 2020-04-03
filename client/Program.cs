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
                FindAllPreferredSuppliersResponse suppList = client.findAllPreferredSuppliers(new FindAllPreferredSuppliersRequest());
                Console.WriteLine("Preffered Suppliers:");
                foreach (Supplier supp in suppList.Suppliers) {
                    Console.WriteLine(supp.Id + "; " + supp.Name + " [" + supp.Phone + "]");
                }
                Product product = new Product {
                    Id = "0000003"
                };
                Supplier supplier = new Supplier {
                    Id = "0000004"
                };
                SetPreferredSupplierForProductRequest request = new SetPreferredSupplierForProductRequest {
                    Supplier = supplier,
                    Product = product
                };
                client.setPreferredSupplierForProduct(request);

                suppList = client.findAllPreferredSuppliers(new FindAllPreferredSuppliersRequest());
                foreach (Supplier supp in suppList.Suppliers) {
                    Console.WriteLine(supp.Id + "; " + supp.Name + " [" + supp.Phone + "]");
                }

                
                Product product2 = new Product {
                    Id = "0000001"
                };
                FindPreferredSupplierRequest request2 = new FindPreferredSupplierRequest {
                    Product = product2
                };
                FindPreferredSupplierResponse response = client.findPreferredSupplier(request2);
                Console.WriteLine(response.Supplier?.Id);

                channel.ShutdownAsync().Wait();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}