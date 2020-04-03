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
                foreach (Supplier supp in suppList.Suppliers) {
                    Console.WriteLine(supp.Id + "; " + supp.Name + " [" + supp.Phone + "]");
                }

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