using System;

namespace Example02_Array2D
{
    internal class Program
    {
        static int[,] map = new int[5, 5] // [행갯수 , 열갯수]
        {
            { 0, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 1, 1 },
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
                    case "MoveLeft":
                        player.MoveLeft();
                        break;
                    case "MoveRight":
                        player.MoveRight();
                        break;
                    case "MoveDown":
                        player.MoveDown();
                        break;
                    case "MoveUp":
                        player.MoveUp();
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
                        Console.WriteLine("▣");
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
                // 맵 범위를 넘어가는지 체크
                if (_x - 1 < 0)
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. 현재위치 : {_x}, {_y}");
                else if (map[_y, _x - 1] != 0)
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. 현재위티 : {_x}, {_y}");
            }

            public void MoveRight()
            {
                map[_y, _x--] = 0;
                map[_y, _x] = 2;
                Console.WriteLine($"플레이어 왼쪽으로 한칸 이동함. 현재위치 : {_x}, {_y}");
            }

            public void MoveDown()
            {

            }

            public void MoveUp()
            {

            }
        }
    }
}
