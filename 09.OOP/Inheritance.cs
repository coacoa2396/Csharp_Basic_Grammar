using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    public class Inheritance
    {
        /**********************************************************************************
        * 상속 (Inheritance)
        *
        * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
        * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
        **********************************************************************************/
        
        // <상속>
        // 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
        // class 자식클래스이름 : 부모클래스이름
        // 부모클래스에 필요한 기능들을 구현해놓으면 하위클래스에 자동적으로 부여가 되므로 많은 기능은 부모클래스에 구현을 하는 것을 추천함
        public class Monster
        {
            public string name;
            public int hp;
            public int damage;
            // 여기에 체력바 구현 --> 모든 몬스터에게 체력바를 구현할 수 있다 = > 부모클래스이기 때문
            // 자식클래스가 상위개념이 아닐 경우 어색해지는 경우가 생길 수 있다
            public void Move()
            {
                Console.WriteLine($"{name} 이/가 움직입니다.");
            }

            public void TakeHit(int damage)
            { 
                hp -= damage;
                Console.WriteLine($"{name}이 {damage}의 데미지를 받아 체력이 {hp}가 되었습니다.");
            }
            public void Attack(Hero hero)
            {
                hero.hp -= damage;
            }
        }

        public class Dragon : Monster
        {
            public Dragon()
            {
                name = "용";
                hp = 100;
                damage = 50;
            }
            public void Breath(Hero hero)
            {
                hero.TakeHit(damage);
                Console.WriteLine($"{name} 이/가 브레스를 뿜습니다.");

            }
            
        }

        public class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 5;
            }

            public void Split()
            {
                Console.WriteLine($"{name} 이/가 분열합니다.");
            }
        }

        public class Hero
        {
            public int name;
            public int damage = 3;
            public int hp = 50;
            public void Attack(Monster monster)
            {
                monster.TakeHit(damage);
            }
            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name}이 {damage}를 받아 체력이 {hp}가 되었습니다");
            }
        }


        void Main1()
        {
            Dragon dragon = new Dragon();
            Slime slime = new Slime();
            Hero hero = new Hero();
            // 부모클래스 Monster를 상속한 자식클래스는 모두 부모클래스의 기능을 가지고 있음
            dragon.Move();
            slime.Move();

            // 자식클래스는 부모클래스의 기능에 자식만의 기능을 더욱 추가하여 구현 가능
            dragon.Breath(hero);
            slime.Split();
            hero.Attack(dragon);
            hero.Attack(slime);




            // 업캐스팅 : 자식클래스는 부모클래스 자료형으로 묵시적 형변환 가능
            Monster monster = new Dragon();  // monster가 현재 드래곤
            hero.Attack(monster);

            // 다운캐스팅 : 부모클래스는 자식클래스 자료형으로 명시적 형변환 가능 (단, 가능할 경우)
            Dragon d = (Dragon)monster;
            // Slime s = (Slime)monster;            // error : 인스턴스(드래곤개체)가 Slime이 아니기 때문에 변환시 오류

            if (monster is Dragon)                  // 형변환이 가능한지 확인
            {
                Dragon isDragon = (Dragon)monster;
            }

            Dragon asDragon = monster as Dragon;
            // 형변환이 가능하다면 형변환
            // 몬스터가 드래곤이 맞다면 asDragon은 드래곤이 된다
            // 몬스터가 드래곤이 아니라면 asDragon은 null이 된다
        }

        // <상속 사용의미 1>
        // 상속을 진행하는 경우 부모클래스의 소스가 자식클래스에서 모두 적용됨
        // 부모클래스와 자식클래스의 상속관계가 적합한 경우 부모클래스에서의 기능 구현이 자식클래스에서도 어울림
        class Fruit
        {
            // 부모클래스에서 기능을 구현할 경우 모든 부모를 상속하는 자식클래스에 기능을 구현하는 효과
            // 과일이 썩는 기능
        }

        class Apple : Fruit
        {
            // 자식클래스에서 자식클래스만의 기능을 구현
            // 과일이 썩는 기능은 자동으로 포함
        }
        // 자식클래스를 생성하는 경우 부모클래스의 기능을 먼저 자식클래스에 구현을 한 뒤
        // 자식클래스의 기능을 생성한다

        // <상속 사용의미 2>
        // 업캐스팅을 통해 자식클래스는 부모클래스로 형변환이 가능함
        // 자식클래스는 부모클래스를 요구하는 곳에서 동일한 기능을 수행할 수 있음
        class Parent
        {
            public void Func() { }
        }
        class Child1 : Parent { }
        class Child2 : Parent { }
        class Child3 : Parent { }

        void UseParent(Parent parent) { parent.Func(); }
        void Main2()
        {
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();
            Child3 child3 = new Child3();

            UseParent(child1);
            UseParent(child2);
            UseParent(child3);
        }
    }
}


