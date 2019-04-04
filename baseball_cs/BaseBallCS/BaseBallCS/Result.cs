using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBallCS;

namespace BaseBallCS
{
    class Result
    {
        public int Strike, Ball, Out;
        
        public bool IsCorrect()
        {
            //todo:하드코드 제거
            return Strike == Constant.Digit;
        }

        internal void Print()
        {
            Console.WriteLine($"결과 : S {Strike}, B {Ball}, O {Out}");
        }


        internal void Cal(Answer answer, Guess guess)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;
            
                if (answer.numbers[i] == guess.numbers[i]) Strike++;
                else if (answer.numbers[i] == guess.numbers[j] || answer.numbers[i] == guess.numbers[k]) Ball++;
                else Out++;
            }
        }
    }
}
