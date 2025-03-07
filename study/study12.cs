// using System;
// using System.Net.Sockets;
// using System.Threading;


// class Program
// {
//     //메모리 영역
//     //스택 int 같은것
//     //힙    new 같은것
//     //정적 메모리 static 외부에 있는걸 가져올수 있다 c#에서 사용
//     static int count = 0;//정적메모리에 기록됨
//     //프로그램 종료까지 존재함

//     //1단계 함수
//     //반환형 함수 이름 (매개변수)
//     //{
//     //}

//     static void Loading()
//     {
//         Console.WriteLine("로딩중.");
//         Thread.Sleep(1000);
//         Console.WriteLine("로딩중..");
//         Thread.Sleep(1000);
//         Console.WriteLine("로딩중...");
//         Thread.Sleep(1000);


//     }

//     // 2단계
//     // 입력
//     static void AttackFunction(int _Attack)
//     {
//         Console.WriteLine("공격력은 : " + _Attack);
//     }

//     //3단계
//     //출력
//     static int BaseAttack()
//     {
//         //기본공격력 10
//         int attack = 10;

//         return attack; //출력
//     }

//     static int Add(int a, int b)
//     {
//         return a + b;

//     }


//     static void Main(string[] args)
//     {
//         // int Attack = 0;
//         // int bAttack = 0;
//         // Console.WriteLine("캐릭터의 공격력을 입력:");
//         // Attack = int.Parse(Console.ReadLine());

//         // //기본공격력
//         // bAttack = BaseAttack();


//         // AttackFunction(bAttack + Attack);

//         //두수를 더하는 함수 만들어서 오류를 해결하세요.
//         // int result = Add(10, 20);
//         // Console.WriteLine($"10 + 20 = {result}");

//         // string[] fruits = { "사과", "바나나", "체리" };

//         // //반복문
//         // foreach (string fruit in fruits)
//         // {
//         //     Console.WriteLine(fruit);
//         // }
//     }
// }
