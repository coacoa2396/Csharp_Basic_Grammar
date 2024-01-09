using System.Runtime.InteropServices;

namespace _06.UserDefineType
{
    internal class Program
    {
        /********************************************************************
         * 열거형 (Enum)
         * 
         * 기본 정수 숫자의 형식의 명명된 상수 집합에 의해 정의되는 값 형식
         * 열거형 멤버의 이름으로 관리되어 코드의 가독성적인 측면에 도움이 됨
         ********************************************************************/

        // <열거형 기본사용>
        //  enum 열거형이름 { 멤버이름, 멤버이름, ...}
        enum Direction {Up,Down,Left,Right}
        void Main1() 
        {
            // 방향 자료형 : 위쪽, 아래쪽, 왼쪽, 오른쪽
            Direction input = Direction.Up;  // 위에서 정의해둔 열거형 안에 있는 것만 사용 가능
            switch (input)
            {
                case Direction.Up:
                    Console.WriteLine("위로 이동");
                    break;
                case Direction.Down:
                    Console.WriteLine("아래로 이동");
                    break;
                case Direction.Left:
                    Console.WriteLine("좌로 이동");
                    break;
                case Direction.Right:
                    Console.WriteLine("우로 이동");
                    break;
            }
        }

        enum EquipType { Head, Body, Foot, Ring }  // 각 장비의 타입을 관리
                                                   // 해당 장비를 해당 부위에만 착용하게 만들수있다

        // <열거형 변환>
        enum Season
        {
            Spring, // 0    // 열거형 멤버에 정수값을 지정하지 않을 경우 0부터 시작
            Summer, // 1    // 열거형 멤버에 정수값을 지정하지 않을 경우 이전 맴버 +1 값을 가짐
            Autumn = 20,    // 정수값을 직접 할당 가능
            Winter  // 21   // 정수값을 직접 할당한 경우에도 이전 멤버 +1 값을 가짐
        }

        void Main2()
        {
            Season season1 = Season.Spring;
            int value1 = (int)Season.Spring;  // 따라서 열거형은 int 변환이 가능하다

            Season season2 = (Season)0;  // 반대로도 형변환이 가능하다
                                         // Season에서 0이 봄이니까 season2의 값은 봄이다
            Season season3 = (Season)11; // season3의 값은 그냥 11로 변환된다
        }

        /**************************************************
         * 구조체 (Struct)
         * 
         * 데이터와 관련 기능을 캡슐화할 수 있는 값 형식
         * 데이터를 저장하기 보관하기 위한 단위용도로 사용
         **************************************************/

        // <구조체 구성>
        // struct 구조체이름 { 구조체내용 }
        // 구조체 내용으로는 변수와 함수가 포함 가능
        struct StudentInfo  // 학생정보
        {
            public string name;  // 학생이름과 시험점수들을 선언
            public int math;
            public int english;
            public int science;

            public float GetAverage()  // 학생정보에 포함된 각종 기능들
                                       // 여기서는 평균점수 계산
            {
                return (math + english + science) / 3f;  // 평균값 계산 함수식
            }
        }

        void Main3()
        {
            StudentInfo kim;            // 구조체 변수 선언
            kim.name = "Kim";           // 구조체내 변수에 접근하기 위해 구조체에 .을 붙여 사용해서 변수 초기화
            kim.math = 10;
            kim.english = 20;
            kim.science = 100;

            float average = kim.GetAverage();   // 구조체내 함수에 접근하기 위해 구조체에 .을 붙여 사용
        }

        struct MonsterStat
        {
            public int hp;
            public int mp;
            public int level;
            public float speed;
            public float range;
            public int exp;
        }
        void Main33()
        {
            MonsterStat slime;
            slime.hp = 10;
            slime.mp = 5;
            slime.level = 1;
            slime.speed = 1.2f;
            slime.range = 3.5f;
            slime.exp = 10;

            MonsterStat goblin;
            goblin.hp = 20;
            goblin.mp = 5;
            goblin.level = 1;
            goblin.speed = 1.5f;
            goblin.range = 3.5f;
            goblin.exp = 15;             // 이런식으로 각 몬스터를 만들어서
                                         // 값을 미리 초기화 해두고 사용 가능
        }

        struct Vector3(float x, float y,float z)  // 좌표 구조체
        {
            public float x; 
            public float y;
            public float z;
        }

        void Main333()
        {
            Vector3 position;   // 현재 위치좌표
            Vector3 Goal;       // 목표 위치좌표 
        }


        // <구조체 초기화>
        // 반환형이 없는 구조체이름의 함수를 초기화라 함
        // 구조체 변수들의 초기화를 진행하는 역할로 사용
        // 매개변수가 있는 초기화를 정의하여 구조체 변수의 값을 설정하기 위한 용도로 사용
        // 구조체의 초기화는 new 키워드를 통해서 사용

        struct Point
        {
            public int x;
            public int y;

            // C#  9.0 이전 버전 : 기본 초기화는 자동으로 생성되며 변경할 수 없음
            // C# 10.0 이후 버전 : 기본 초기화를 추가하지 않는 경우 자동으로 생성되며 추가하여 변경 가능
            /*public Point()
            {
                this.x = 0;
                this.y = 0;
            }*/

            public Point(int x, int y)  // 초기화 함수, 매개변수 앞에 보통 언더바
            {
                this.x = x;  // 위에 있는 변수를 사용할때는 앞에 this.을 붙이면 된다
                this.y = y;  // this : 자기 자신을 가리킴
            }
        }

        void Main4()
        {
            Point point1;
            point1.x = 1;  // x값만 초기화했기 때문에 y값은 나오지않는다
            Console.WriteLine($"{point1.x}");
            Console.WriteLine($"{point1.y}");// y값도 따로 초기화를 해줘야 한다(기본 초기화를 안했을 경우!)

            Point point2 = new Point(2, 3);  // 초기화 함수를 사용했기 때문에 x, y값 둘 다 나온다
            
            Point point3 = new Point();  // 기본초기화
            Console.WriteLine($"{point3.x}");  // 기본값이 들어가있다
            Console.WriteLine($"{point3.y}");  // 기본값이 들어가있다
        }


        // <구조체 깊은복사>
        // 구조체에 대입연산자(=)를 통해 구조체 내 모든 변수들의 값이 복사됨

        struct MyStruct
        {
            public int value1;
            public int value2;
        }

        void Main5()
        {
            MyStruct s;
            s.value1 = 1;
            s.value2 = 2;

            MyStruct t = s;     // 구조체 내 모든 변수들의 값이 복사됨
            t.value1 = 3;       // 복사 후 대입을 하니까 t의 value1은 3이 된다
                                // t의 value2는 s의 value2 값을 갖고 있다

            Console.WriteLine(s.value1);    // 1
            Console.WriteLine(s.value2);    // 2

            Console.WriteLine(t.value1);    // 3
            Console.WriteLine(t.value2);    // 2
        }

        // <튜플> : 쓰지마! -> 구조체 만들어!


        static void Main(string[] args)
        {
            
        }
    }
}
