using AwesomeProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeProxyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            FooFormBiz biz = ProxyFactory.GetProxyInstance<FooFormBiz>();
            //FooFormBiz biz = new FooFormBiz();            

            var formData = biz.LoadFormData("F0001");

            string result = biz.SaveFormData(formData);

            Console.WriteLine($"result: {result}");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
