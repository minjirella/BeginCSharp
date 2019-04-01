using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자동완성 - Ctrl + Space
            Console.WriteLine("Hello world");

            // 합계를 저장할 변수를 준비
            // 1부터 100까지를 반복.
            // 만약 3의 배수라면 sum에 더함.
            // sum을 출력.
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    // 가장 원초적인 디버깅. 원초적이고 무식하다,
                    //Console.WriteLine($"sum = {sum} i = {i}");
                    Console.WriteLine("sum = {0}, i = {1}", sum, i);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
