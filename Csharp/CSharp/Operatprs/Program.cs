using System;
using System.Numerics;

namespace UnityLesson_CSharp_Operator
{
    class Program
    {
        static int a = 14;
        static int b = 5;
        static int c;

        static void Main(string[] args)
        {
            // 산술 연산   
            // 더하기, 빼기, 나누기, 곱하기, 나머지 
            //================================================================== 
            // 더하기  
            c = a + b;
            Console.WriteLine(c);
            // 빼기 
            c = a - b;
            Console.WriteLine(c);
            // 나누기 , 정수를 나누기하면 결과값에서 소수점은 버린다. 
            c = a / b;
            Console.WriteLine(c);
            // 곱하기 
            c = a * b;
            Console.WriteLine(c);
            // 나머지 
            c = a % b;
            Console.WriteLine(c);

            // 증감 연산 
            // 증가 연산자, 감소 연산자 
            //================================================================== 

            //증가연산 
            c++; // c = c + 1; 
            Console.WriteLine(c);
            //감소연산 
            c--; // c = c - 1 ; 
            Console.WriteLine(c);
            // 관계 연산 
            // 같음 , 다름, 크기 비교 연산 
            // 관계 연산의 결과가 참이면 true, 거짓이면 false 를 반환. 
            //================================================================== 
            //같음 비교 
            Console.WriteLine(a == b);
            //다름 비교 
            Console.WriteLine(a != b);
            //크다  
            Console.WriteLine(a > b);
            //작다 
            Console.WriteLine(a < b);
            //크거나 같다 
            Console.WriteLine(a >= b);
            //작거나 같다 
            Console.WriteLine(a <= b);

            // 대입 연산 
            // (더해서, 빼서, 나누어서, 곱해서, 나머지를) 대입 
            //================================================================== 
            c = 20;
            Console.WriteLine($"Last C value : {c}");
            c += b; // c = c + b; 
            Console.WriteLine(c);
            c -= b; // c = c - b; 
            Console.WriteLine(c);
            c /= b; // c = c / b; 
            Console.WriteLine(c);
            c *= b; // c = c * b; 
            Console.WriteLine(c);
            c %= b; // c = c % b; 
            Console.WriteLine(c);

            // 논리 연산 
            // 양측의 피연산자들을 비교해서 연산 수행 
            // or , and , xor, not 
            //================================================================== 

            bool A = true;
            bool B = false;
            // or  
            // a 와 b 둘중 하나라도 true 이면 true 반환, 나머지 경우 false 반환 
            Console.WriteLine(A | B);

            // and 
            // a와 b 둘다 true 일때만 true 반환 , 나머지 경우 false 반환 
            Console.WriteLine(A & B);

            // xor 
            // a 와 b 둘중에 하나만 true 일때 true 반환, 나머지 경우 false 반환 
            Console.WriteLine(A ^ B);
            // not  
            // a 의 반대 부호 반환 ( true 이면 false, false 이면 true 반환) 
            Console.WriteLine(!A);

            // 조건부 논리연산 
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다. 
            //================================================================================= 

            // or 조건부 논리연산 
            // 만약 A 가 true 이면 B 의 값에 관계없이 결과값이 true 이므로  
            // 연산을 하지 않고 A 값을 반환함. 
            Console.WriteLine(A || B);
            // and 조건부 논리연산 
            //만약 A 가 false 이면 B 의 값에 관계없이 결과값이 false 이므로 
            // 연산을 하지 않고 A 값을 반환함. 
            Console.WriteLine(A && B);

            // 비트 연산 
            // 비트연산 하는 이유 : 데이터를 효율적으로 관리하기 위함  
            // or, and, xor , not shift-left, shift-right 
            int howManyBitYouWantToShift = 1;
            // or 
            Console.WriteLine(a | b);
            // and 
            Console.WriteLine(a & b);
            // xor 
            Console.WriteLine(a ^ b);
            // not 
            Console.WriteLine(~a);
            // shift- left 
            Console.WriteLine(a << howManyBitYouWantToShift);
            // shift- right 
            Console.WriteLine(a >> howManyBitYouWantToShift);

            // 조건부 논리 연산자
            // conditional or / conditional and
            //==========================================================

            // conditional or
            // 앞쪽 피연산자가 false 일경우 뒤의 피연산자 연산하지 않고 바로 true 변환
            Console.WriteLine(A || B);

            // conditional and
            // 앞쪽 피연산자가 false 일경우 뒤의 피연산자 연산하지 않고 바로 false 변환
            Console.WriteLine(A == B);

            // 비트 연산자
            // or, and, xor, not, shift-left, shift-right,
            //==============================================

            // or ( 앞쪽 피연산자가 1 일경우 1 )
            Console.WriteLine(a | b);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // b == 6 ==        2^2 + 2^1 == ...00000110
            // or result                  == ...00001110 == 14

            // and ( 앞쪽 피연산자가 0 일경우 0 )
            Console.WriteLine(a | b);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // b == 6 ==        2^2 + 2^1 == ...00000110
            // or result                  == ...00000110 == 6

            // 324 == (10^2 * 3) + (10^1 * 2) + (10^0 * 4)
            // 324 == 256 + 64 + 4 = (2^8 * 1) + (2^6 * 1) + (2^2 *1)
            //     == .. 00000001 01000100

            // xor ( 서로 다를 경우 1 )
            Console.WriteLine(a ^ b);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // b == 6 ==        2^2 + 2^1 == ...00000110
            // xor result                 == ...00001000 == 8

            // not
            Console.WriteLine(a ^ b);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // not resurt                 == 11111111111111111111111110001;
            // 2의 보수 : 이진법에서 모든자리수를 반전하고 + 1
            // (a = -a) == (a = ~a + 1);

            // shift - left
            Console.WriteLine(a << 1);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // shift - left result        == ...00011100

            // shift - right
            Console.WriteLine(a << 2);
            // a == 14 == 2^3 + 2^2 + 2^1 == ...00001110
            // shift - right result        == ...00000011
        }
    }

  

    // ex) 플레이어가 Idle 상태면 마을로 귀환이 가능하고, 피격당한상태와 공격중인 상태일때 // 귀환이 불가능하게 설정하고 싶으면  
    // 플레이어의 FSM 을 만들어서 상태를 나누고 귀환이 가능한 조건을 구분한다.  
    // 즉 사용자가 귀환 버튼을 눌렀을때 , IDLE 상태면 귀환 모션이 실행되면서 귀환을 시전하지만 //, 몬스터에게 피격당하거나 공격중인 상태일때 귀환 버튼을 누르면  FSM 조건에 따라 귀환이 //불가능하게 한다.  
    [Flags]
    public enum e_FSM
    {
        IDLE = 0,
        피격당한상태 = 1 << 0,
        공격중인상태 = 1 << 1,
        STATE_3 = 1 << 2,
        STATE_4 = 1 << 3,
    }
}