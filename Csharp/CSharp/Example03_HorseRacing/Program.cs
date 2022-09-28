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

namespace Example03_HorseRacing
{
    public class Horse
    {
        public string Name;
        public float distance;
        public int grade;
        public bool IsFinished;

        public void Run(float distance)
        {
            position += distance;
        }

    }
    

    internal class Program
    {
        const int TOTAL_HOLSES_NUMBER = 5;
        public Horse horses = new Horse(TOTAL_HOLSES_NUMBER);

        public void Main(string[] args)
        {
            for (int i = 0; i < TOTAL_HOLSES_NUMBER;  i++)
            {
                horses[i];
            };

        }
    }
}
/* dk dksrud enrhdhktj tndjq shgcuTek
 * 
 * gk tlqkf wlsWK doal
 * 
 * tlqkf whssk djfuqsp wlsWk ahtgoajrrpTdj
 * 
 * ro tlqkf wlsWK sjan djfuqek
 * 
 * ajflRowlfRJrkxdk
 * 
 * tlqkf wktkfakfuqsp
 * 
 * wlqdprkrhtlvek
 * 
 * rmsid dhwlakfRjf
 * 
 * dksrud tlqkf codrudhfRjf
 * 
 * qhrh emfdms ahemsrjtdmf dmltlagofk
 * 
 * sjrk wpdlf wkfskwl dksgdkTek rmrjs vudtod qusgkwl dksgsms tktlfdlek
 * 
 * dnfl rm snrneh wkfskwl dksgdkTekdddfffd