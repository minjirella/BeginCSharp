using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointer
{
    class Cat
    {
        public Cat(int hp)
        {
            HP = hp;
        }
        public int HP;
    }

    struct Snake
    {
        public Snake(int hp)
        {
            HP = hp;
        }
        public int HP;
    }

    class Program
    {
        static void Foo(Snake a)
        {
            //snake a라는 객체를 만들고, 아래main의 s1을 복사해온다.
            //코드로 표현하면 Foo(s1)을했을때, 여기서 생략된 구문은 Snake a = s1 이 되겠다. 
            a.HP = 5;
        } // s1과 a가 동시생성되고, 중괄호가 닫혀서 a는 소멸된다.

        static void Foo(Cat a) // 오버로딩 : 오버라이드와는 다른, 같은함수에서 다른 매개변수를 사용하는 함수를 생성. (다형성)
        { 
          // 매개변수는 지역변수 a로 바뀌고 c1을 복사해온다.(c1의 값은 힙에있는 주소를 값으로 가지고있음)
          // Cat 클래스는 참조타입이므로, c1의 값은 힙에있는 hp값이 저장되어있음.
          //코드로 표현하면 Foo(c1)을했을때, 여기서 생략된 구문은 Cat a = c1 이 되겠다. 
            a.HP = 5;
        } // c1과 a가 생성되있고, a는 소멸. 그러나, 힙에있는 hp값은 앞의 지역변수 때문에 5로 변경되어, 출력값은 5.


        static void Main(string[] args)
        {
            //Snake - 구조체 Struct, Cat - 클래스 Class
            
            Snake s1 = new Snake(1); // 스택에서만 Snake 의 공간이 생긴다. 구조체 - 값타입
            Foo(s1);
            Console.WriteLine("(After Foo) Snake1 : " + s1.HP);

            Snake s2 = s1;
            s1.HP = 3;
            Console.WriteLine("Snake1 : " + s1.HP);
            Console.WriteLine("Snake2 : " + s2.HP);

            Cat c1 = new Cat(1);
            Foo(c1);
            Console.WriteLine("(After Foo) Cat1 : " + c1.HP);

            Cat c2 = c1;
            c1.HP = 3;
            Console.WriteLine("Cat1 : " + c1.HP);
            Console.WriteLine("Cat2 : " + c2.HP);
        }
    }

}
