using Excample01_Classproject;
using System;
using System.Xml.Linq;

// orc 라는 클래스 작성 예제
// Orc 는
// 이름, 키, 몸무게, 나이, 성별문자, 쉬고있는지아닌지? 에대한 특징을 가지고있으며(멤버변수)
// 휘드르기 (Smash), 점프하기(Jump) 라는 기능(멤버함수)를 가지고 있어야한다
// Orc 클래스를 작성한후
//
// Main 함수 내에서 Orc 객체를 두개 만듭니다.
// 첫번째 객체는
// 이름 : 상급오크
// 키 : 240.2
// 몸무게 : 200
// 나이 : 149
// 쉬고있는지? : false
//
// 두번째 객체는
// 이름 : 하급오크
// 키 : 140.4
// 모무게 : 120.0
// 나이 60
// 성별 문자 : 여
// 쉬고있는지 : true
//
// 2. 각 오크들이 쉬고있는지 체크한후 쉬고있는 오크에게 점프와 휘두르기를 시전시킵니다
// (멤버함수 호출)
namespace Excample01_Classproject
{

    // Naming convention
    // PascalCase
    // camelCase
    // snake_case
    //
    // 클래스이름 , 함수이름은 Pascalcase
    // public 변수 : Pascalcase
    // privite 변수 : _camelcase
    // 지역변수 : camelCase
    // 상수 : UPPER_SNAKE_CASE / SNAKE_CASE
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.Name = "상급오크";
            Console.WriteLine($"이름 : {orc1.Name}");
            orc1.Height = 240.0f;
            Console.WriteLine($"키 : {orc1.Height}");
            orc1.Age = 149;
            Console.WriteLine($"나이 : {orc1.Age}");
            orc1.GenderCharacter = '남';
            Console.WriteLine($"성별 : {orc1.GenderCharacter}");
            orc1.IsReseting = false;
            Console.WriteLine($"쉬고있는가? : {orc1.IsReseting}");


            Orc orc2 = new Orc();
            orc2.Name = "하급오크";
            Console.WriteLine($"이름 : {orc2.Name}");
            orc2.Height = 140.4f;
            Console.WriteLine($"키 : {orc2.Height}");
            orc2.Age = 60;
            Console.WriteLine($"나이 : {orc2.Age}");
            orc2.GenderCharacter = '여';
            Console.WriteLine($"성별 : {orc2.GenderCharacter}");
            orc2.IsReseting = true;
            Console.WriteLine($"쉬고있는가? : {orc2.IsReseting}");

            if (orc1.IsReseting)
            {
                orc1.Smash();
                orc1.Jump();
            }

            if (orc2.IsReseting)
            {
                orc2.Smash();
                orc2.Jump();
            }
        }
    }

    public class Orc
    {
        private bool _camelcase;
        public int Age;
        public float Height;
        public double weight;
        public bool IsReseting;
        public char GenderCharacter;
        public string Name;

        // 함수
        public void Smash()
        {
            Console.WriteLine(Name + "(이)가 도끼를휘두른다");
        }

        public void Jump()
        {
            Console.WriteLine(Name + "(이)가 힘차게 튀어오른다");
        }

    }




}
