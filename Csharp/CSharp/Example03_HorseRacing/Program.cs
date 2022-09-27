/* 프로그램 시작시
말 다섯마리를 만들고
각 다섯마리는 초당 10~20 (정수형) 범위 거리를 랜덤하게 움직임
각각의 말이 거리 200 에 도달하면 말의 이름과 등수를 출력해줌

말은
이름, 달린거리 를 멤버변수로
달리기 를 멤버 함수로 가짐.
달리기 멤버함수는 입력받은 거리를 달린거리에 더해주어서 달린거리를 누적시키는 역할을 함.

매초 달릴 때 마다 각 말들이 얼마나 거리를 이동했는지 콘솔창에 출력해줌.
경주가 끝나면 1,2,3,4,5 등 말의 이름을 등수 순서대로 콘솔창에 출력해줌.

### - Hint - ###

System.Threading namespace 에 있는 Thread.Sleep(1000); 를 사용하면 현재 프로그램을 1초 지연시킬수 있음
While 반복문에서 Thread.Sleep(1000); 을 추가하면 1초에 한번씩 반복문을 실행함. */

// ??? 외계어인가
using System;
using System.Diagnostics;
using System.Threading;

Random rand = new Random();

namespace Example03_HorseRacing
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Horse horse1 = new Horse();
            horse1.Name = "1번말";
            horse1.distance = 0;

            while (horse1.distance < 200 )
            {
                horse1.Run();
                if (horse1.distance < 200)
                {
                    horse1.finished();
                    horse1.grade = ++horse1.grade;
                    break;
                    Console.WriteLine($"1번말이 {grade}번째로 들어왔습니다. ");
                }
            }

            Horse horse2 = new Horse();
            horse2.Name = "2번말";
            horse2.distance = 0;
            while (horse2.distance < 200)
            {
                horse2.Run();
                if (horse2.distance < 200)
                {
                    horse2.finished();
                    horse2.grade = ++horse2.grade;
                    break;
                }
            }

            Horse horse3 = new Horse();
            horse3.Name = "3번말";
            horse3.distance = 0;
            while (horse3.distance < 200)
            {
                horse3.Run();
                if (horse3.distance < 200)
                {
                    horse3.finished();
                    horse3.grade = ++horse3.grade;
                    break;
                }
            }

            Horse horse4 = new Horse();
            horse4.Name = "4번말";
            horse4.distance = 0;
            while (horse4.distance < 200)
            {
                horse4.Run();
                if (horse4.distance < 200)
                {
                    horse4.finished();
                    horse4.grade = ++horse4.grade;
                    break;
                }
            }

            Horse horse5 = new Horse();
            horse5.Name = "5번말";
            horse5.distance = 0;
            while (horse5.distance < 200)
            {
                horse5.Run();
                if (horse5.distance < 200)
                {
                    horse5.finished();
                    horse5.grade = ++ horse5.grade;
                    break;
                }
            }

        }
    }
}





public class Horse
{
    public string Name;
    public float distance;
    public int grade;
    public void finished()
    {

    }

    public void Run()
    {
        distance += Random(10, 20);
        Thread.Sleep(1000);
    }

    public float Random(int v1, int v2)
    {
        throw new NotImplementedException();
    }

}
