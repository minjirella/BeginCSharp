using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooGooDan
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.SelectNum();
            
            Result result = new Result();
            result.Cal(num);
            result.Print(num);
        }
    }
}
