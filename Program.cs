using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleCopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Output1();
            Output2();
            Output3();

            bool result = Test();
            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }

        private static void Output1()
        {
            Console.WriteLine("output 1");
        }

        private static void Output2()
        {
            Console.WriteLine("output 2");
        }
        private static void Output3()
        {
            Console.WriteLine("output 3");
        }

        private static bool Test()
        {
            return true && false;
        }
    }
}