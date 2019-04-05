using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooGooDan
{
    class Result
    {
        public void Cal(Number num)
        {
            for (int i = 1; i < Constant.MaxNumber; i++)
            {
                int result = Convert.ToInt32(num) * i;
                Console.WriteLine($"{num} * {i} = {result}");
            }
        }

        public void Print(Number num)
        {
            Console.WriteLine($"실행하신 구구단은 {num}단입니다.");
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
