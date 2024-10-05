using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(args[0]);
            int n2 = int.Parse(args[1]);

            int result = n1 / n2;
            Console.WriteLine("The value of result is = " + result);
        }
    }
}
