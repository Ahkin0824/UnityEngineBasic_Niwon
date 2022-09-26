// using
// C#의 키워드 
// using 말그대로 나는 ~를 사용하겠다

// System 
// C# 코드가 기본적으로 필요로 하는 클래스를 담고있는, 즉 namespace안에있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할을 함.
using System;
// 키워드 : namespace 
// 클래스 간의 멤버 이름 충돌을 방지함.
namespace UnityLesson_CSharp_StaticExample
{
    // class (아직 잘 모른다.)
    // class는 제목과 비슷하다
    // 즉 이 선언된 변수(필드)들은 class 아래에서 논다
    // 즉 클래스는 설계도이다
    // 실체(인스턴스)가 아니다
    class Program
    {
        // 키워드 : static (아직 뭔지 잘 모르겠다)
        // static(정적) 은 dynamic(동적) 과 반대되는 개념의 키워드로  
        // 인스턴스화 시킬 수 없다 라는것을 의미함
        // 즉 하나만 존재할 수 있다

        // void 
        // 반환값의 타입이 없다.(이게 무슨뜻인지 아직 잘 모른다.)
        // 함수는 기본적으로 
        // 입력 -> 기능(이득) -> 출력 의 기본 형식을 지니는데,  
        // 함수에서 입력을 바탕으로한 기능만 실행하고 출력을 아무것도 하지 않는경우 
        // void 라는 반환 타입을 사용한다.  
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "오크";
            orc1.height = 240.0f;
            Orc.typeName = "오크 타입 설계도";
            Orc.SayTypeName();

            // static 멤버(변수와 함수) 는 객체 단위로 접근할수가 없다. 
            // static 으로 정의된 클래스는 인스턴스화가 불가능하다. 
            // Person person1 = new Person(); // <- static 클래스이므로 인스턴스화 불가능하여 에러남 
        }
    }

    class Orc
    {
        // 접근제한자  
        // 자료형 앞에 붙어서 해당 변수/함수/클래스의 접근 권한을 지정한다. 
        // public , private , protected  
        // public : 다른 클래스에서 접근 가능  
        // private : 다른 클래스에서 접근이 불가능 
        // protected : 상속자만 접근 가능  
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderChar;
        public bool isResting;

        // static 키워드는 정적 성질을 부여하는 키워드. 
        // 정적 이라는거는 메모리에 할당할 수가 없다라는 뜻.  
        // 반대로 동적은 메모리 할당이 가능하다. 
        static public string typeName;
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }

        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다");
        }
    }

    static class Person
    {
        // static class 를 쓰는 이유 : 
        // 객체를 찍어내는것이아니라, 정보,기능,개념등이 유일하게 필요한경우 사용 
        //  
    }
}
