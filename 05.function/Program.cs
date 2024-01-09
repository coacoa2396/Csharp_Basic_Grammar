using Microsoft.Win32.SafeHandles;
using static System.Net.Mime.MediaTypeNames;

namespace _05.function
{
    internal class Program
    {
        /****************************************************************
        * 함수 (Function)
        *
        * 미리 정해진 동작을 수행하는 코드 묶음
        * 어떤 처리를 미리 함수로 만들어 두면 다시 반복적으로 사용 가능
        ****************************************************************/

        // 점프
        // 1. 위쪽 방향을 키리키게 한 뒤
        // 2. 가리킨 방향으로 힘을 가한다.
        // 3. 가해진 힘이 중력보다 크면
        // 4. 그만큼 속도를 갖는다.

        // <함수 구성>
        // 일련의 코드를 하나의 이름 아래에 묶음

        // 반환형 함수이름(매개변수들) { 함수 내용 }
        // 함수이름은 대문자 시작이 국룰

        static int Plus(int left, int right)
        {
            Console.WriteLine($"Input : {left}, {right}");
            int result = left + right;
            Console.WriteLine($"Output : {result}");
            return result;
        }
        // 출력 이름(입력값) { 동작 }


        // <함수 사용>
        // 함수로 구성해둔 코드를 이름으로 불러 사용함


        static void Main1(string[] args)
        {
            // 더할때마다 매번 하지말고
            // 위에 만든 것을 함수로 만들어서 적용시킨다.
            Plus(1, 3);     // result : 4
            Plus(2, 4);     // result : 6
            Plus(3, 5);     // result : 8






        }

        // <반환형 (Return Type)>
        // 함수의 결과(출력) 데이터의 자료형
        // 함수가 끝나기 전까지 반드시 return으로 반환형에 맞는 데이터를 출력해야함
        // 함수 진행 중 return을 만나는 경우 그 즉시 결과 데이터를 반환하고 함수가 종료됨
        // 함수의 결과(출력)이 없는 경우 반환형은 void이며 return을 생략 가능

        static int/*자료형이 있으면*/ Return10()
        {
            Console.WriteLine("도달하는 코드");
            return 10;  // return으로 결과값을 정해준다.

            // return 이후 코드는 진행되지 않음
            Console.WriteLine("도달하지 못하는 코드");
        }

        static void/*실행자체에 의미가 있으면*/ PrintProfile(string name, string phone)
        {
            Console.WriteLine($"이름 : {name}, Phone : {phone}");
            //return을 생략해도 된다
        }

        static void Main2()
        {
            int ret = Return10();

            PrintProfile("홍길동", "010-1234-1234");
            PrintProfile("감자왕", "010-4567-4567");
        }


        // <매개변수 (Parameter)>
        // 함수에 추가(입력)할 데이터의 자료형과 변수명
        // 같은 함수에서도 매개변수 입력이 다름에 따라 다른 처리가 가능

        static int Minus(int left, int right)
        {
            // 함수의 입력으로 넣어준 매개변수 left, right에 따라 함수가 동작
            return left - right;
        }

        static void Main4()
        {
            int a = Minus(20, 10);
            int b = Minus(30, 20);
        }


        // <함수 호출 순서>
        // 함수는 호출 되었을 때 해당 함수 블록으로 제어가 전송되며
        // 완료되었을 때 원위치로 제어가 전송됨

        static int TripleShot()
        {
            int damage = 0;
            for (int i = 0; i < 3; i++)
            {
                damage += Attack();
            }
            return damage;
        }

        static int Attack()
        {
            Console.WriteLine("공격!");
            return 10;
        }

        static void Main5()
        {
            int totalDamage = TripleShot();
            Console.WriteLine($"전체 데미지는 {totalDamage}입니다.");
        }

        // <함수 오버로딩>
        // 같은 이름의 함수를 매개변수를 달리하여 다른 함수로 재정의하는 기술
        // 같은 이름의 함수를 호출하여도 매개변수의 자료형에 따라 함수를 달리 호출할 수 있음

        static int Multi(int left, int right) { return left * right; }
        static float Multi(float left, float right) { return left * right; }
        static double Multi(double left, double right) { return left * right; }

        static void Main()
        {
            int result1 = Multi(1, 2);
            float result2 = Multi(1.3f, 2.5f);
            double result3 = Multi(1.2d, 3.3d);
        }




    }
}
