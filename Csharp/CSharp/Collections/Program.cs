using System;
using System.Collections;
using System.Collections.Generic;

// 함수는 스택 영역에 쌓임

// 지역 변수는 같이 할당됨
// 컴퓨터는 
// 스택 영역에 맨위에 있는 함수만 실행함
// 실행한 함수는 삭제함
// 하지만 라인은 기억하기에 반복 되지않음


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            int a = 3;
            object obj = a; // 박싱 : 객체를 힙 영역에 할당하고 기존값을 가지고 있게 한다.
            a = (int)obj; // 언박싱 : 힙영역에 할당 되어 있던 객체로 부터 기존 값을 가져오는 과정
            string s = ""; // "" 내용의 string 객체를 힙영역에 할당하고

            ArrayList arrayList = new ArrayList();
            arrayList.Add(3); // 3을 박싱 후 해당 참조를 추가한다
            // ArrayList 는 object[] 에다가 데티어를 저장한다.
            // ArrayList 는 object[] 의 크기를 데이터를 저장할때마다 부족하면 동적으로 늘린다
            arrayList.Add("정신 나갈꺼같애");
            arrayList.Add('D');
            arrayList.Add(array);
            arrayList.Remove('D');
            arrayList.Insert(1, 'A');

            // Stack
            // LIFO (Last Input First Output)
            Stack stack = new Stack();
            stack.Push(3); // 아이템 젤 마지막에 추가
            stack.Push(4);
            Console.WriteLine(stack.Peek()); // 제일 먼저 빠질 객체를 반환
            stack.Pop(); // 젤 마지막에 들어온 아이템 빼고 반환
            stack.Pop();

            // Queue
            // FIFO (First Input First Output)
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(queue.Peek()); // 젤먼저 빠질 객체 반환
            queue.Dequeue(); // 젤앞에 있는 아이템 빼고 반환
            queue.Dequeue();

            Hashtable hashtable= new Hashtable();
            hashtable.Add("철수", 240.0f);
            Console.WriteLine((float)hashtable["철수"]);

            //
            //
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Remove(3);
            list.RemoveAt(0);

            // LinkedList<T>
            // C# 의 Doubly-Linked list 일반형
            LinkedList<float> LinkedList = new LinkedList<float>();
            LinkedList.AddLast(3.0f);
            LinkedList.Remove(3.0f);
            LinkedList.RemoveFirst();


        }
    }
}
