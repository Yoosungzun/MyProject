// using System;


// // class MyResource
// // {
// //     //소멸자
// //     ~MyResource()
// //     {
// //         Console.WriteLine("삭제될 때 호출");
// //     }
// // }

// class Program
// {
//     //ref 포인터개념 참조조
//     //메서드 ref, out
//     static void Increase(ref int x)
//     {
//         x++;
//     }
//     //out은 반환이 여러개일때 유용하다.
//     static void OutFunc(int a, int b, out int x, out int y)
//     {
//         x = a;
//         y = b;
//     }

//     static void Main(string[] args)
//     {
//         // MyResource r = new MyResource();
//         // //GC에 의해 나중에 소멸자 호출

//         // //가비지 컬렉션은 더이상 참조되지 않는 객체를 정리합니다.

//         int a = 10;
//         int b = 20;
//         // Increase(ref a);

//         // Console.WriteLine("A의 값 : " + a);
//         int x, y;
//         OutFunc(a, b, out x, out y);

//         Console.WriteLine($"x :{x} y : {y}");
//     }
// }