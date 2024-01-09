using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _14.Delegate.Callback;

namespace _14.Delegate
{
    public class Callback 
    {
        /*******************************************************************************
        * 콜백함수
        * 
        * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
        * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
        *******************************************************************************/


        public class Player
        {
            public void Jump() { Console.WriteLine("점프합니다"); }
            public void Dash() { Console.WriteLine("대쉬합니다"); }            
            public void Attack() { Console.WriteLine("공격합니다"); }
        }
        public class Button
        {
            public Action OnClick;

            public virtual void Click()
            {
                if (OnClick != null) 
                    OnClick();                 
            }
        }

        public static void Main()
        {
            Player player = new Player();
            
            Button jumpButton = new Button();
            jumpButton.OnClick = player.Jump;

            Button dashButton = new Button();
            dashButton.OnClick = player.Dash;            
        }
        public void MainMenu() { Console.WriteLine("메뉴창을 엽니다."); }
        public void Setting() { Console.WriteLine("설정창을 엽니다."); }
        public void Continue() { Console.WriteLine("계속 진행합니다."); }
    }
}
