using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallCS
{
    class NumberContainer
    {
        protected int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            return numbers[index];
        }

        public void Print()
        {
            //  todo : 둘중 하나만 출력. 가상함수 반영예정.
            Console.Write("[추측] ");
            Console.Write("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
