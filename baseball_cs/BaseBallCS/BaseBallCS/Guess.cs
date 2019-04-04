using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallCS
{
    class Guess : NumberContainer //Guess는 NumberContainer의 자식으로 상속을 받는다.
    {
        public void Input()
        {
            int[] numbers = new int[Constant.Digit];
            for (int i = 0; i < numbers.Length; i++) // property
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
