using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooGooDan
{
    class Number
    {
        public int SelectNum()
        {
            int num;
            while (true)
            {
                Console.Write("숫자 하나를 고르시오 : (1~9)");
                num = Convert.ToInt32(Console.ReadLine());

                if (num <= Constant.MinNumber || num >= Constant.MaxNumber)
                {
                    Console.WriteLine("다시 입력해주세요!");
                    continue;
                }
                else break;
            }
            return num;
        }
    }
}
