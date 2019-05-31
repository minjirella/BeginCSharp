using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegatePractice.Person;

namespace delegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(32, "김과장");
            person.AgeChanged += Person_AgeChanged; // 기존 : AgeChangedEventArgs(Person_AgeChanged)의 축약형, 함수가 아니다 delegate를 받아와서 함수정의가 필요함.

            person.IncreaseAge();
        }

        private static void Person_AgeChanged(object sender, AgeChangedEventArgs e)
        {
            //birthYear 변수가 알려지지 않았기 때문에 컴파일 에러
            Console.WriteLine($"{e.OldAge} -> {e.NewAge}");
        }
    }
}
