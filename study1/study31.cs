// using System;
// using System.Diagnostics;
// using System.Text;
// using Microsoft.VisualBasic;

// class Prrogram
// {
//     static void Main(string[] args)
//     {
//         //값 형식과 참조 형식
//         //값 형식은 스택에 저장되고 , 참조형식은 힙에 저장됩니다.

//         // int valueType = 10;
//         // object referenceType = valueType;

//         // valueType = 20;

//         // Console.WriteLine($"ValueType : {valueType}"); //20
//         // Console.WriteLine($"ReferenceType: {referenceType}");

//         //박싱 언박싱
//         //갑 형식을 참조형식으로 변혼(박싱) , 다시 값 형식으로 변환 (언박싱)

//         // int value = 42;
//         // object boxed = value;//박싱
//         // int unboxed = (int)boxed; //언박싱

//         // Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");

//         //is 연산자 형식 비교하기
//         //객체가 특정 형식인지 확인할수 있다.
//         // object obj = " Hello";

//         // Console.WriteLine(obj is string); //true
//         // Console.WriteLine(obj is int);//false

//         //as 연산자로 형식 변환하기
//         //as 연산자를 사용해 안전하게 형 변환을 수행한다.

//         // object obj = "Hello";
//         // string str = obj as string;

//         // Console.WriteLine(str is string);

//         // object obj = 42;

//         // if (obj is int number)
//         // {
//         //     Console.WriteLine($"Number : {number}");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("Not a number");
//         // }

//         //문자열 다루기

//         // string greeting = "Hello";
//         // string name = "Alice";

//         // string message = greeting + "," + name + "!";
//         // Console.WriteLine(message);

//         // Console.WriteLine($"Length of name : {name.Length}"); //무자열 길이
//         // Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
//         // Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열 인덱스가 1번인것부터 시작해라

//         // string 다양한 메서드
//         // string text = "C# is awesome!";
//         // Console.WriteLine($"Cotains ' awesome' : {text.Contains("awesome")}");
//         // Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
//         // Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
//         // Console.WriteLine($"Replace 'awesom' with 'great' : {text.Replace("awesome", "great")}");

//         // StringBuilder sb = new StringBuilder("Hello");
//         // sb.Append(",");
//         // sb.Append("World!");
//         // Console.WriteLine(sb.ToString());

//         //반복적으로 문자열을 수정할때 stringBuilder가 효율적이다.

//         // int iteractions = 10000;
//         // Stopwatch sw = Stopwatch.StartNew();

//         // string text = "";

//         // for (int i = 0; i < iteractions; i++)
//         // {
//         //     text += "a";
//         // }

//         // sw.Stop();
//         // Console.WriteLine($"string : {sw.ElapsedMilliseconds}ms");

//         // sw.Restart();
//         // StringBuilder sb = new StringBuilder();

//         // for (int i = 0; i < iteractions; i++)
//         // {
//         //     sb.Append("a");
//         // }

//         // sw.Stop();
//         // Console.WriteLine($"string : {sw.ElapsedMilliseconds}ms");

//         //예외처리하기

//         //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지 안혹
//         //실행을 계속할 수 있습니다.
//         //try catch

//         // try
//         // {
//         //     int[] numbers = { 1, 2, 3 };
//         //     Console.WriteLine(numbers[5]);//오류 발생
//         // }
//         // catch (IndexOutOfRangeException ex)
//         // {
//         //     Console.WriteLine($"Error : {ex.Message}");
//         // }

//         //finally 블록은 예외 발생여부와 상관 없이 항상 실행됩니다.

//         // try
//         // {
//         //     int number = int.Parse("NotANumber");
//         // }
//         // catch (FormatException ex)
//         // {
//         //     Console.WriteLine($"Format Error : {ex.Message}");
//         // }
//         // finally
//         // {
//         //     Console.WriteLine("항상 실행됩니다.");
//         // }

//         // try
//         // {
//         //     int number = int.Parse("abc");
//         // }
//         // catch (Exception ex)
//         // {
//         //     Console.WriteLine($"General Error : {ex.Message}");
//         // }
//         // try
//         // {
//         //     int age = -5;
//         //     if (age < 0)
//         //     {
//         //         throw new ArgumentException("Age cannot be negative");
//         //     }
//         // }
//         // catch (Exception ex)
//         // {

//         //     Console.WriteLine($"exception : {ex.Message}");

//         // }

//     }

// }