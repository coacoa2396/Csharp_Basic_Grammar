using System.ComponentModel.Design;

namespace _03.Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
            * 조건문 (Conditional)
            *
            * 조건에 따라 실행이 달라지게 할 때 사용하는 문장
            ****************************************************************/



            /****************************************************************
            * if 조건문
            *
            * 조건식의 true, false에 따라 실행할 블록을 결정하는 조건문
            ****************************************************************/

            // < if 조건문 기본>

            int playerHP = 100;
            int monsterAtk = 20;
            
            if (playerHP > monsterAtk) //조건식을 () 안에 넣는다
            {
                // 조건식의 결과가 true라면 if블록이 실행
                Console.WriteLine("플레이어가 데미지를 받습니다.");
                playerHP -= monsterAtk;
            }
            else //조건 이외에는
            {
                 // 조건식의 결과가 false라면 else블록이 실행됨
                Console.WriteLine("플레이어가 쓰러집니다.");
                playerHP = 0;
            }
            // 조건이 맞으면 if실행 else생략
            // 조건이 안맞으면 if생략 else실행

            // else 블록은 선택사항으로 필요없을 경우 넣지 않아도 된다

            bool isJumpPressed = true;
            bool isGround = true;
            if (isGround && isJumpPressed)
            {
                Console.WriteLine("점프한다.");
             }
            /*else                    // 이런경우는 생략 가능
            {
                // 아무것도 안함
            }*/


            // else if 문을 추가함으로 여러 조건을 확인할 수 있음
            // 가위, 바위, 보
            string input = "바위";
            if (input == "가위")
            {
                Console.WriteLine("입력한 값이 가위일때 처리");
            }
            else if (input == "바위")
            {
                Console.WriteLine("입력한 값이 바위일때 처리");
            }
            else if (input == "보")
            {
                Console.WriteLine("입력한 값이 보일때 처리");
            }
            else
            {
                Console.WriteLine("잘못 입력 함.");
            }



            int score = 65; // 60점이하 아이언, 61~70 브론즈, 71~80 실버, 81~90 골드, 91~100 플레

            if (score <= 60)
            {
                Console.WriteLine("당신은 아이언입니다"); 
            }
            else if (score <= 70) // 위에서 이미 걸렀기 때문에 &&를 사용하지 않아도 된다.
            {                     // 다만 순서가 바뀌어서 먼저 안걸러지면 이상하게 나올 가능성이 있다.
                Console.WriteLine("당신은 브론즈입니다");
            }
            // 이하생략



            /****************************************************************
             * switch 조건문
             *
             * 조건값에 따라 실행할 시작지점을 결정하는 조건문
             ****************************************************************/

            
            // < switch 조건문 기본>
            char c = 'B';
            switch (c)              // 조건값 지정
            {
                // 각 case별로 블록을 만든다
                case 'A':
                    Console.WriteLine("조건값이 A인 경우 실행");
                    break;
                case 'B':
                    Console.WriteLine("조건값이 B인 경우 실행");
                    break;
                case 'C':
                    Console.WriteLine("조건값이 C인 경우 실행");
                    break;
                default:  // 모든 case에 해당하지 않는 경우
                    Console.WriteLine("값이 그 외 이다.");
                    break;
            }

            // switch 조건문이 사용되는 경우
            // 조건값에 따라 동일한 실행이 필요한 경우 묶어서 사용 가능
            char key = 'w'; // wasd로 움직이는 경우
            switch (key)
            {
                case 'w':                         // 세개 중에
                case 'W':                         // 무엇이 입력되든
                case 'ㅈ':                        // 같은 동작을 실행한다
                    Console.WriteLine("위쪽으로 이동");
                    break;
                case 'a':
                case 'A':
                case 'ㅁ':
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case 's':
                case 'S':
                case 'ㄴ':
                    Console.WriteLine("아래쪽으로 이동");
                    break;
                case 'd':
                case 'D':
                case 'ㅇ':
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("이동하지 않음");
                    break;
            }

            // 조건식의 경우는 if
            // 조건값의 경우는 switch 가 보통은 편하다
            // 상황에 맞게 사용하자


            /****************************************************************
            * 삼항연산자
            *
            * 간단한 조건문을 빠르게 작성
            ****************************************************************/

            // <삼항 연산자 기본>
            // 조건 ? true인 경우 값 : false인 경우 값
            int left = 11;
            int right = 22;

            int bigger1 = left > right ? left : right;
            //               조건식    ? 맞을때: 아닐때
           
            
            int bigger2;         // 둘 중 큰거를 넣는다
            if (left >  right)
            {
                bigger2 = left;
            }
            else
            {
                bigger2 = right;
            }
            // if로 만든면 간단한데 길다



        }
    }
}
