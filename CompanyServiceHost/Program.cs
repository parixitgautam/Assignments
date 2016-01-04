using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CompanyServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(CompanyService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("Host service started @" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
