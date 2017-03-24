using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenexDemoPrint;

namespace XenexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageCases = new Dictionary<int, string>();
            messageCases.Add(3, "fizz");
            messageCases.Add(5, "buzz");
            foreach (string message in XenexPrint.GenerateMessages(20, messageCases))
                Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
