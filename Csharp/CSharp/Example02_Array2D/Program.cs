using System;

namespace Example02_Array2D
{
    internal class Program
    {
        // 3차원배열

        // static int[,,] = new int[3, 4, 5,]
        
        // 0 은 갈수 있는 길 , 1은 벽

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

