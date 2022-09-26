using System;

// 구조체
// 사용자 정의 자료형
// 멤버변수, 멤버함수를 가짐
// 생성자가 있음.
/* (단 생성자는 매개변수로 모든맴버 변수에
    대응되는 파라미터를 가지고 있어야 하며,
    생성자호출시 모든멤버변수는 초기화 되어야 한다.) */
// 왜 멤버변수가 초기화 되어야 하냐?
// 구조체는 값 형식이고 스택영역에 할당되기 때문.


// 구조체 VS 클래스
// 모든 멤버의 크기 합이 16byte를 초과할 경우 클래스를 사용한다.
// 값의 전달이 빈번하게 일어나는 경우 구조체를 쓴다.
// ex : 함수에 인자로 전달해야 하는경우
// 잠깐 썼다가 사라지는 경우가 잦을때 구조체를 쓴다.
// ex : 클래스 타입 객체 해제시 가비지 컬렉션 부하 증가

// 가비지컬렉션이란?
// https://www.notion.so/f27a1263326b47eca852eca8ee264b2a?v=7bfefd70637241e0b8dfbff65acb319e&p=abbb2475f4114b89b254c83f1dde2c86&pm=s

namespace Structure
{
    public struct Stats
    {
        // alt + shift + 마우스 커서 = 다중선택
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;

        public int CalcCombatPoint ()
        {
            return STR + DEX + INT + LUK;
        }
    }

    public class Warrior
    {
        public Stats Stats;
    }

    public class Stats_Class
    {
        public Stats Stats;
    }

    public struct WarriorFamily
    {
        public Warrior Warrior1; //스택영역에 참조 주소만 가지고있음.
        public Warrior Warrior2; 
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // 스택영역에 할당
            Stats stats = new Stats()
            {
                STR = 100,
                INT = 200,
                DEX = 400,
                LUK = 800
            };

            Stats_Class stats_Class = new Stats_Class()
            {
                STR = 100,
                INT = 200,
                DEX = 400,
                LUK = 800
            }

            Warrior warrior = new Warrior();
            // warrior.Stats 는 힙영역에 할당.
            Console.WriteLine(stats.CalcCombatPoint());
        }
    }
}
