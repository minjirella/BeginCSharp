using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //알고리즘 기술 단계
            // 1 정답을 생성( 이는 중복이 되어서는 안된다. 0~9사이의 3개의 정수)
            int answer1, answer2, answer3;
            int guess1, guess2, guess3;
            int tryCount = 0;
            Random randNum = new Random();
            while (true)
            {// 지역변수 선언은 항상 그 중괄호 시작에서 끝까지만 유효하다.
                answer1 = randNum.Next(10);
                answer2 = randNum.Next(10);
                answer3 = randNum.Next(10);
                if (answer1 != 0)
                {
                    if (answer1 != answer2 && answer1 != answer3 && answer2 != answer3)
                        break;
                }
            }
            Console.WriteLine($"정답 : {answer1}{answer2}{answer3}");
            // - while
            while (true)
            {
                tryCount++;
                // 2 추측 수를 호출 -> 입력받는다
                // -> 두 가지로 형변환 하는 방법이있다 str->int
                guess1 = int.Parse(Console.ReadLine());
                guess2 = Convert.ToInt32(Console.ReadLine());
                guess3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"추측 : {guess1}{guess2}{guess3}");

                // 3 정답과 추측을 비교하여 결과를 계산
                // 3-1 정답 숫자와 같을경우 Ball, 정답 숫자에 indexNum까지 맞을 경우 Strike, 아웃
                int strike = 0;
                int ball = 0;
                int @out = 0;

                if (answer1 == guess1) strike++;
                else if (answer1 == guess2 || answer1 == guess2) ball++;
                else @out++;
                if (answer2 == guess2) strike++;
                else if (answer2 == guess1 || answer2 == guess3) ball++;
                else @out++;
                if (answer3 == guess3) strike++;
                else if (answer3 == guess1 || answer3 == guess2) ball++;
                else @out++;

                // 4 결과를 출력
                Console.WriteLine($"결과 : S {strike}, B {ball}, O {@out}");

                // 5 정답과 추측이 일치하지 않으면 2번으로 돌아간다.
                // 5-1 정답의 조건 : 3 Strike

                if (strike == 3) break;
            }

            // 정답을 맞추는데 걸리는 횟수를 출력. 종료.
            // 위 항 tryCount 참고.
            Console.WriteLine($"{tryCount}회 만에 정답입니다");
        }
    }
}
