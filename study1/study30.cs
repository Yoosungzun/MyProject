// using System;
// using System.Diagnostics;
// using System.Text.RegularExpressions;
// using System.Threading;

// //클래스시그니처 기본구성
// //c#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

// //[접근 지정자] [수정자] class 클래스 이름 : 부모클래스 , 인터페이스
// //public        abstract                 : BaseClass , Icomparable
// //private       sealed
// //protected     static
// //              partial

// //기본 클래스
// public class Player
// {
//     public string Name { get; set; }
//     public int Score { get; set; }
// }

// //상속하는 클래스
// public class Warrior : Player
// {
//     public int Strength { get; set; }
// }
// //인터페이스를 구현하는 클래스
// // public class Enemy: IAttackable, Imovable
// // {
// //     public void Attack() {}

// //     public void Move(){}
// // }
// //추상 클래스(abstract)
// public abstract class Animal
// {
//     public abstract void MakeSound();
// }
// class Program
// {


//     static void Main(string[] args)
//     {
//         // Console.WriteLine("프로그램 종료");

//         // string path = Environment.GetEnvironmentVariable("PATH");
//         // Console.WriteLine($"PATH: {path}");
//         // Environment.Exit(0);

//         // Random random = new Random();

//         // int randomNumber = random.Next(1, 101);
//         // Console.WriteLine("랜덤 숫자 : " + randomNumber);

//         //프로그램 실행 시간 구하기

//         // Stopwatch stopwatch = Stopwatch.StartNew();

//         // //실행코드
//         // for (int i = 0; i < 100; i++)
//         // {
//         //     Thread.Sleep(1);
//         // }

//         // stopwatch.Stop();

//         // Console.WriteLine($"for 시간 : " + stopwatch.ElapsedMilliseconds);

//         // string input = "Hello, my phone numver is 010 -1234-5678.";
//         // string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴

//         // bool isMathch = Regex.IsMatch(input, pattern);
//         // Console.WriteLine($"전화번호가 존재하는가? {isMathch}");






//     }
// }