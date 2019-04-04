using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBallCS;


namespace BaseBallCS
{
    class Answer
    {
        public int[] numbers = new int[Constant.Digit];


        public void Create()
        {
            Random randNum = new Random();
            int[] numbers = new int[Constant.Digit];

            while (true)
            {// 지역변수 선언은 항상 그 중괄호 시작에서 끝까지만 유효하다.
                for (int i = 0; i < Constant.Digit; i++) numbers[i] = randNum.Next(Constant.MaxValue);

                // todo: 추후 수정
                if (numbers[0] != 0)
                {
                    if (numbers[0] != numbers[1] && numbers[0] != numbers[2] && numbers[1] != numbers[2])
                        break;
                }
            }
        }

        public void Print()
        {
            Console.Write("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
