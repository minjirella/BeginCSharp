using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBallCS;

namespace BaseBall
{
    class Program
    {
        //상수 정의 : const 로 변하지않는 숫자로 정의, 후에 최대치 변경이
        // 이루어지면 그때 해당값만 변경 해주면 된다.
        //const int MaxVal = 10;
        //const int Digit = 3;


        /// <summary>
        /// 숫자 배열을 출력한다.
        /// </summary>
        /// <param name="prefix">숫자 출력전에 출력할 문자열</param>
        /// <param name="numbers">출력할 숫자</param>
        static void PrintNum(string prefix, int[] numbers) //매개변수의 성질을 파악해서 명사로 정의하고
            // 함수의 역할을 파악해서 동사로 명명하도록 하자.
        {
            Console.Write(prefix);
            for (int i = 0; i < Constant.Digit; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine("");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //알고리즘 기술 단계
            // 1 정답을 생성( 이는 중복이 되어서는 안된다. 0~9사이의 3개의 정수)
            int tryCount = 0;
            Random randNum = new Random();
            int[] answers = new int[Constant.Digit];
            int[] guesses = new int[Constant.Digit];

            while (true)
            {// 지역변수 선언은 항상 그 중괄호 시작에서 끝까지만 유효하다.
                for(int i=0; i< Constant.Digit; i++) answers[i] = randNum.Next(Constant.MaxValue);

                // todo: 추후 수정
                if (answers[0] != 0)
                {
                    if (answers[0] != answers[1] && answers[0] != answers[2] && answers[1] != answers[2])
                        break;
                }
            }

            PrintNum("[정답] ", answers);

            // - while
            while (true)
            {
                tryCount++;
                // 2 추측 수를 호출 -> 입력받는다
                // -> 두 가지로 형변환 하는 방법이있다 str->int
                for (int i = 0; i < guesses.Length; i++) // property
                {
                    guesses[i] = Convert.ToInt32(Console.ReadLine());
                }
                PrintNum("[추측] ", guesses);

                // 3 정답과 추측을 비교하여 결과를 계산
                // 3-1 정답 숫자와 같을경우 Ball, 정답 숫자에 indexNum까지 맞을 경우 Strike, 아웃
                Result result = new Result();

                result.Cal(answers, guesses);

                // 4 결과를 출력
                result.Print();

                // 5 정답과 추측이 일치하지 않으면 2번으로 돌아간다.
                // 5-1 정답의 조건 : 3 Strike
                if (result.IsCorrect()) break;
            }

            // 정답을 맞추는데 걸리는 횟수를 출력. 종료.
            // 위 항 tryCount 참고.
            Console.WriteLine($"{tryCount}회 만에 정답입니다");
        }
    }
}
