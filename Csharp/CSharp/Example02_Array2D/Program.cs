// 파랑색글자는 키워드
// 키워드(예약어)란 ? 미리 정의되어있는 단어
// 이미 문법용도로 사용되고있기때문에 식별용으로 개발자가 쓸 수 없다.
// using 은 무언가를 사용하겠다고 선언하는 키워드

// using
// C#의 키워드 
// 말그대로 나는 ~(보통 System)을/를 사용하겠다

// System 
// C# 코드가 기본적으로 필요로 하는 클래스를 담고있는,
// 즉 namespace안에있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할을 함.
using System;

// 키워드 : namespace 
// 클래스 간의 멤버 이름 충돌을 방지함.
namespace Example02_Array2D
{

    // class (아직 잘 모른다.)
    // 선언된 변수(필드)들은 class 아래에서 논다
    // 즉 클래스는 설계도이다
    // 실체(인스턴스)가 아니다
    internal class Program
    {
        // 배열(array)이란?
        /* 배열(array)은 같은 타입의 변수들로 이루어진 유한 집합으로 정의됩니다.

        배열을 구성하는 각각의 값을 배열 요소(element)라고 하며, 배열에서의 위치를 가리키는 숫자는 인덱스(index)라고 한다.

        C언어에서 인덱스는 언제나 0부터 시작하며, 0을 포함한 양의 정수만을 가질 수 있다.

        배열은 같은 종류의 데이터를 많이 다뤄야 하는 경우에 사용할 수 있는 가장 기본적인 자료 구조이다.
        
        배열은 선언되는 형식에 따라 1차원 배열, 2차원 배열뿐만 아니라 그 이상의 다차원 배열로도 선언할 수 있다.
        하지만 현실적으로 이해하기가 쉬운 2차원 배열까지가 많이 사용된다. */



        // 2 차원 배열
        static int[,] map = new int[5, 5]
        {
            { 0, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 1 ,1 },
            { 1, 1, 0, 0, 0 },
            { 0, 1, 1, 0, 0 }
        };
        
        static void Main(string[] args)
        {
            Player player = new Player(3, 0);
            map[0, 3] = 2;
        
            while (true)
            {
                string input = Console.ReadLine();
        
                switch (input)
                {
                    case "L":
                        player.MoveLeft(map);
                        break;
                    case "R":
                        player.MoveRight(map);
                        break;
                    case "D":
                        player.MoveDown(map);
                        break;
                    case "U":
                        player.MoveUp(map);
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
        
                DisplaMap();
            }
        }
        
        static void DisplaMap()
        {
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (map[j, i] == 0)
                        Console.Write("□");
                    else if (map[j, i] == 1)
                        Console.Write("■");
                    else if (map[j, i] == 2)
                        Console.Write("▣");
                }
                Console.WriteLine();
            }
        }
        
        class Player
        {
            private int _x;
            private int _y;
        
            public Player(int x, int y)
            {
                _x = x;
                _y = y;
            }
        
            public void MoveLeft(int[,] map)
            {
                // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
                if (_x - 1 < 0)
                {
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (맵의 경계)");
                }
                // 이동하려는 위치가 이동가능하면 이동
                else if (map[_y, _x - 1] == 0)
                {
                    map[_y, _x--] = 0;
                    map[_y, _x] = 2;
                    Console.WriteLine($"플레이어 왼쪽으로 한칸 이동. 현재 위치 {_x}, {_y}");
                }
                // 이동하려는 위치가 벽이면 이동안함
                else if (map[_y, _x - 1] == 1)
                {
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (벽)");
                }
            }
        
            public void MoveRight(int[,] map)
            {
                // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
                if (_x + 1 > map.GetLength(1) - 1)
                {
                    Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (맵의 경계)");
                }
                // 이동하려는 위치가 이동가능하면 이동
                else if (map[_y, _x + 1] == 0)
                {
                    map[_y, _x++] = 0;
                    map[_y, _x] = 2;
        
                    Console.WriteLine($"플레이어 오른쪽으로 한칸 이동. 현재 위치 {_x}, {_y}");
                }
                // 이동하려는 위치가 벽이면 이동안함
                else if (map[_y, _x + 1] == 1)
                {
                    Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (벽)");
                }
            }
        
            public void MoveUp(int[,] map)
            {
                // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
                if (_y - 1 < 0)
                {
                    Console.WriteLine($"플레이어를 위쪽으로 이동시킬 수 없습니다. (맵의 경계)");
                }
                // 이동하려는 위치가 이동가능하면 이동
                else if (map[_y - 1, _x] == 0)
                {
                    map[_y--, _x] = 0;
                    map[_y, _x] = 2;
                    _y--;
                    Console.WriteLine($"플레이어 위쪽으로 한칸 이동. 현재 위치 {_x}, {_y}");
                }
                // 이동하려는 위치가 벽이면 이동안함
                else if (map[_y - 1, _x] == 1)
                {
                    Console.WriteLine($"플레이어를 위쪽으로 이동시킬 수 없습니다. (벽)");
                }
            }
        
            public void MoveDown(int[,] map)
            {
                // 이동하려는 위치가 맵의 경계를 넘어가는지 체크
                if (_y + 1 > map.GetLength(0) - 1)
                {
                    Console.WriteLine($"플레이어를 아랫쪽으로 이동시킬 수 없습니다. (맵의 경계)");
                }
                // 이동하려는 위치가 이동가능하면 이동
                else if (map[_y + 1, _x] == 0)
                {
                    map[_y++, _x] = 0;
                    map[_y, _x] = 2;
                    _y++;
                    Console.WriteLine($"플레이어 아랫쪽으로 한칸 이동. 현재 위치 {_x}, {_y}");
                }
                // 이동하려는 위치가 벽이면 이동안함
                else if (map[_y + 1, _x] == 1)
                {
                    Console.WriteLine($"플레이어를 아랫쪽으로 이동시킬 수 없습니다. (벽)");
                }
            }
        }
    }
}

