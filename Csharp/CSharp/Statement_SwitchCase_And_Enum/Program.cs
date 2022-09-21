using System;
using System.Net.Http.Headers;

namespace Statement_SwitchCase_And_Enum
{
    // enum 열거형 사용자정의 자료형
    // 기본적으로 System.int32 자료형
    enum PlayerStates
    {
        Idle,   // == ...00000000
        Move,   // == ...00000001
        Jump,   // == ...00000010
        Dash,   // == ...00000001
        Attack, // == ...00000100
        Hurt,   // == ...00000101
        Die     // == ...00000110
    }


    //flags 속성은 enum 타입의 tostring() 변환시에 각 비트별로 string 변환해주는 속성이다/
    [System.Flags]
    enum Layer
    {
        None     = 0 << 0,  // == ...00000000
        Player   = 1 << 0,  // == ...00000001
        Enemy    = 1 << 1,  // == ...00000010
        obstacle = 1 << 2,  // == ...00000100
        NPC      = 1 << 3,  // == ...00001000
        Wall     = 1 << 4   // == ...00010000
            // targetlayer  // == ...00000111
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player other = new Player();
            Enemy enemy = new Enemy();
            obstacle obstacle = new obstacle();
            NPC NPC = new NPC();
            wall wall = new wall();


            Player player = new Player();
            player.state = PlayerStates.Attack;

            Console.WriteLine(player.targetLayer);

            switch (player.state)
            {
                case PlayerStates.Idle:
                    Console.WriteLine("플레이어는 아무것도 안하고있다");
                    break;
                case PlayerStates.Move:
                    Console.WriteLine("플레이어는 움직이고있다");
                    break;
                case PlayerStates.Jump:
                    Console.WriteLine("플레이어는 점프하고있다");
                    break;
                case PlayerStates.Dash:
                    Console.WriteLine("플레이어는 돌진하고있다");
                    break;
                case PlayerStates.Attack:
                    {
                        Console.WriteLine("플레이어는 공격하고있다");

                        if ((other.layer & player.targetLayer) == other.layer)
                        Console.WriteLine($"{player} 는 {other}를 공격한다");
                        
                        if ((other.layer & player.targetLayer) == enemy.layer)
                        Console.WriteLine($"{player} 는 {enemy}를 공격한다");

                        if ((other.layer & player.targetLayer) == obstacle.layer)
                        Console.WriteLine($"{player} 는 {obstacle}를 공격한다");

                        if ((other.layer & player.targetLayer) == other.layer)
                        Console.WriteLine($"{player} 는 {enemy}를 공격한다");


                    }
                    break;
                case PlayerStates.Hurt:
                    Console.WriteLine("플레이어는 공격받고있다");
                    break;
                case PlayerStates.Die:
                    Console.WriteLine("플레이어는  죽어가고있다");
                    break;
                default:
                    break;
            }

        }
    }

    class Player
    {

        public Layer layer = Layer.Player;
        public Layer targetLayer = Layer.Player | Layer.Enemy | Layer.obstacle;
        public PlayerStates state;

        public void Attack()
        {

        }

    }

    class Enemy
    {

        public Layer layer = Layer.Enemy;

    }

    class obstacle
    {

        public Layer layer = Layer.obstacle;

    }

    class NPC
    {

        public Layer layer = Layer.NPC;

    }

    class wall
    {

        public Layer layer = Layer.Wall;

    }





}
