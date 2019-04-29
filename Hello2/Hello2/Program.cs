using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void foo(Snake s) { s.Age++; }
        static void foo(Cat c) { c.Age++; }

        static void Main(string[] args)
        {
            Snake s1 = new Snake(); // Snake s1; 값타입이기 때문에, 사용가능
            Cat c1 = new Cat(); // Cat c1;(X)

            foo(s1); // s1.Age == 0

            foo(c1); // c1.Age == 1

            DateTime today;

            object[] ar = new object[3];
            ar[0] = new Cat();
            ar[1] = new Snake();
            ar[2] = 3;

            Console.WriteLine(ar);

        }

        static int CountA(object o)
        {
            String str = o.ToString().ToLower();

            return str.Count(x => x == 'a');
        }
    }
}
