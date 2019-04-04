using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallCS
{
    class Guess
    {
        private int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            return numbers[index];
        }


        public void Input()
        {
            int[] numbers = new int[Constant.Digit];
            for (int i = 0; i < numbers.Length; i++) // property
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        public void Print()
        {
            Console.Write("[추측] ");
            for (int i = 0; i < Constant.Digit; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }

    }
}
