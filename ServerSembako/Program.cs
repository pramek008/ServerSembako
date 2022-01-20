using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using ServiceSembako;

namespace ServerSembako
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(Service1));
                hostObjek.Open();
                Console.WriteLine("Server siap");
                Console.ReadLine();
                hostObjek.Close();
            }
            catch(Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
        }
    }
}
