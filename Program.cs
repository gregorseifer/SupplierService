using System;
using Grpc.Core;

namespace Suppliers
{
    class Program
    {
        const int Port = 50051;
        public static void Main(string[] args)
        {
            try
            {    
                TestData.insertTestData();
                Server server = new Server
                {
                    Services = { global::SupplierService.BindService(new SupplierImpl()) },
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };
                server.Start();
                Console.WriteLine("Supplier server listening on port " + Port);
                Console.WriteLine("Press any key to stop the server...");
                Console.ReadKey();
                server.ShutdownAsync().Wait();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }    
}
