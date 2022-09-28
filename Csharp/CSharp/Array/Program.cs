// 파랑색글자는 키워드
// 키워드(예약어)란 ? 미리 정의되어있는 단어
// 이미 문법용도로 사용되고있기때문에 식별용으로 개발자가 쓸 수 없다.
// using 은 무언가를 사용하겠다고 선언하는 키워드
using System;

// 키워드 : namespace 
// 클래스 간의 멤버 이름 충돌을 방지함.

// array
// 형태 : 자료형[]
// 자료형이 정적으로 나열되어있는 형태,
// 한번 크기를 정하면 일반적으로는 바꿀 수 없다.
namespace Array
{
    /* 보통 우리는 클래스의 멤버 접근 권한을 제어하기 위해 
     * public, protected, private 이렇게 세가지를 많이들 쓰는데 */

    // 평소 사용이 드문 Internal이라는 접근제어자가 하나 더 있다.

    // Internal은 다른 접근제한자와 달리
    // 'Internal의 접근 권한을 가진 멤버는 동일 어셈블리 내에서만' 사용할 수 있다

    // 사용방법은 다른 제어자와 똑같다.

    // class (아직 잘 모른다.)
    // 이 선언된 변수(필드)들은 class 아래에서 논다
    // 즉 클래스는 설계도이다
    // 실체(인스턴스)가 아니다
    internal class Program
    {
        // 키워드 : static (아직 뭔지 잘 모르겠다)
        // static(정적) 은 dynamic(동적) 과 반대되는 개념의 키워드로  
        // 인스턴스화 시킬 수 없다 라는것을 의미함
        // 즉 하나만 존재할 수 있다

        // void
        // 반환값의 타입이 없다.(이게 뭔지 잘 모른겠다)
        // 함수는 기본적으로 
        // 입력 -> 기능(이득) -> 출력 의 기본 형식을 지니는데,  
        // 함수에서 입력을 바탕으로한 기능만 실행하고 출력을 아무것도 하지 않는경우 
        // void 라는 반환 타입을 사용한다.  
        static void Main(string[] args)
        {
            // 배열
            // * 참조 형식
            // 연속적인 메모리
            // 자료형[] 변수이름 = new 자료형[배열크기];
            // 자료형[] 변수이름 = { 원소1, 원소2, 원소3, ...};

            // array
            // 형태 : 자료형[]
            // 자료형이 정적으로 나열되어있는 형태,
            // 한번 크기를 정하면 일반적으로는 바꿀 수 없다.
            int[] arrInt = new int[10];
            // arrInt2 는 int 형 배열 참조 변수
            // arrInt 는 주소만 알고있다

            // int 는 integer의 약자로, '정수' 라는 의미이다
            // int a; 를 입력해 주면 a 라는 이름을 가진 하나의 정수형 변수가 선언된다.
            // 이 int a;를 확인한 컴파일러는
            // 비어있는 컴퓨터 저장 공간 중 4 byte (32 bit) 를 이 변수에게 할당하고 a 라는 이름을 붙이는 것
            int[] arrInt2 = {1, 2, 3};
            
            // float
            //
            // 정수(integer)도 매우 좋지만 때때로 매우 큰 숫자나 소수점이 있는 숫자를 저장해야 하는 경우도 있다.
            // 그래서
            // C 언어에는
            // float, double 및 long double 과 같은 부동 소수점 자료형이 있다.
            // float은 4 byte이고 double은 8이며 long double은 8, 12, 16 byte 중 하나다.
            float[] arrFloat = new float[4];

            // 인덱서를 통한 요소 접근
            // 인덱서는 0부터 시작
            // arrint 는 int 형
            arrInt[0] = 3;
            arrInt[1] = 2;
            arrInt[2] = 1;

            // 콘솔(Console) 클래스는 "System" 네임 스페이스에서 사용할 수 있다.
            // 콘솔 클래스에서 사용할 수 있는 모든 속성과 함수는 정적이므로,
            // Console 인스턴스를 생성하지 않아도 Console 이름으로 속성과 함수를 사용할 수 있습니다

            // Console 클래스의 함수
            // WriteLine(문자열) 콘솔 창에 문자열을 출한 후 커서를 다음 줄로 이동합니다.
            // WriteLine(변수) 콘솔 창에 변수 값을 출력 후 커서를 다음 줄로 이동합니다.
            Console.WriteLine(arrInt[0]);
            Console.WriteLine(arrInt[1]);
            Console.WriteLine(arrInt[2]);
            //arrInt[x] = arrInt주소로가서 arrInt 제일 앞의 주소부터 0 * int 타입 크기 만큼 뒤에있는 주소로부터 int 타입 크기만큼 읽는다

            // string
            // 말 그대로 string(문자열)을 다루는 클래스이다.
            string name = "Luke";   // string 은 참조형식
            Console.WriteLine(name[1]);

            // char
            // char는 2바이트(16비트) 정수형 처리 변수로 character(문자)의 약자
            // int 와 마찬가지로
            // char a; 를 입력해 주면 a 라는 이름을 가진 하나의 정수형 변수가 선언된다.
            char[] arrChar = new char[5];
            arrChar[0] = 'L';
            arrChar[1] = 'u';
            arrChar[2] = 'k';
            arrChar[3] = 'e';
            arrChar[4] = '\0'; // null 문자. 모든비트 0 인 문자. 문자열의 끝을 식별하기위한 용도

            string[] arrString = new string[3];
            arrString[0] = "김아무개";
            arrString[1] = "이아무개";
            arrString[2] = "박아무개";
            Console.WriteLine(arrString[0]);

            // 집가서 먼저 복습하기
            
        }
    }
}
