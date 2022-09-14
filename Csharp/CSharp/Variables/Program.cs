using System;


namespace Variables
{
    internal class Program
    {
        //bit : 한자리 이진수 (0, 1로 표현)
        // byte : 8 bit ( CPU 의 데이터 처리 최소단위 )
        
        // 변수
        int index = 3; // int 는 4byte 부호가 있는 정수형
        // index 는 3으로 초기화되었다.
        // index 변수의 메모리공간에 3 이라는 데이터를 대입
        // 7 == 2 & 2 + 2 ^ 1 + 2 ^ 0

        // 함수
        static void Main(string[] args)
        {
           
        }
    }
   

    public class Human
    {
        int age; // 4 byte 실수형
        double weight; // 8 byte 실수형 
        bool isReseting; // 1 byte 논리형
        // true : 0이 아님, false : 0
        char genderCharacter; // 2byte 문자형
        // 97 == 64 + 32 + 1 == 2^6 + 2^5 + 2^0
        string name; // 문자열형, 문자갯수 * 2 byte + 1 byte (null)
    }
}
