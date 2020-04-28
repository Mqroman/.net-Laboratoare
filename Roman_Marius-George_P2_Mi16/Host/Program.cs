using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ObjectWCF;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost Host = new ServiceHost(typeof(ModelAndApi),
            new Uri("http://localHost:8000/PC"));
            foreach (ServiceEndpoint dd in Host.Description.Endpoints)
                Console.WriteLine("A(address): {0}\n B (binding):  {1} \n C(Contract): {2} \n", dd.Address, dd.Binding.Name, dd.Contract.Name);
            Host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati  Enter pentru a opri serverul!");
            Console.ReadKey();
            Host.Close();
        }
    }
}
