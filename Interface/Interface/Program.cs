using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program : InterfaceTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interface");
            InterfaceTest t = new Program();
            t.test();
        }

        public void test()
        {
            Console.WriteLine("test");
        }

        //private static void test()
        //{
        //    Console.WriteLine("test");
        //}
    }
}
