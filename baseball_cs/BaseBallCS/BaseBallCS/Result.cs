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


        internal void Cal(int[] answers, int[] guesses)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 1) % Constant.Digit;
            
                if (answers[i] == guesses[i]) Strike++;
                else if (answers[i] == guesses[j] || answers[i] == guesses[k]) Ball++;
                else Out++;
            }
        }
    }
}
