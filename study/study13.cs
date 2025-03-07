// using System;
// using System.Security.Cryptography.X509Certificates;

// class Program
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static void Main(string[] args)
//     {
//         // 문제: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
//         // int[] numbers = { 10, 20, 30, 40, 50 };
//         // foreach (int num in numbers)
//         // {
//         //     Console.Write(num + " ");
//         // }
//         // Console.WriteLine();

//         // 문제: 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.
//         // int[] sum = new int[5];
//         // int sum1 = 0;
//         // Console.WriteLine("정수를 5번 입력하세요.:");
//         // for (int i = 0; i < 5; i++)
//         // {
//         //     sum[i] = int.Parse(Console.ReadLine());
//         //     sum1 += sum[i];
//         // }
//         // Console.WriteLine($"합계는 : {sum1} 입니다");




//         // 문제: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
//         // int[] numbers = { 3, 8, 15, 6, 2 };
//         // int max;
//         // max = numbers[0];
//         // for (int i = 0; i < numbers.Length; i++)
//         // {
//         //     if (numbers[i] > max)
//         //     {
//         //         max = numbers[i];
//         //     }
//         // }
//         // Console.WriteLine($"최대값은 : {max} 입니다.");



//         // 문제: for문을 사용하여 1부터 10까지 출력하세요.

//         // for (int i = 1; i <= 10; i++)
//         // {
//         //     Console.Write(i + " ");
//         // }


//         // 문제: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
//         // int a = 1;
//         // while (a <= 10)
//         // {
//         //     if (a % 2 == 0)
//         //     {
//         //         Console.Write(a + " ");
//         //     }

//         //     a++;
//         // }



//         // 문제: foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.
//         // int[] numbers = { 1, 2, 3, 4, 5 };
//         // foreach (int num in numbers)
//         // {
//         //     Console.Write(num + " ");
//         // }



//         // 문제: 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
//         // Console.WriteLine("두개의 정수를 입력하세요.");
//         // int a = int.Parse(Console.ReadLine());
//         // int b = int.Parse(Console.ReadLine());
//         // int resault = Add(a, b);
//         // Console.WriteLine($"합계는 {resault} 입니다.");



//         // 문제: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
//         // Console.WriteLine("아무 글자나 작성하세요.");
//         // string input = Console.ReadLine();
//         // Console.WriteLine($"글자의 총 길이는 {input.Length} 입니다.");


//         // 문제: 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
//         // int[] num = new int[3];
//         // int max = num[0];
//         // Console.WriteLine("3개의 정수를 입력하세요.");
//         // for (int i = 0; i < 3; i++)
//         // {
//         //     num[i] = int.Parse(Console.ReadLine());
//         //     if (num[i] > max)
//         //         max = num[i];
//         // }
//         // Console.WriteLine($"가장 큰수는 {max} 입니다.");

//         // int[] arr = new int[5];
//         // int sum = 0;
//         // float aver = 0f;
//         // for (int i = 0; i < 5; i++)
//         // {
//         //     arr[i] = int.Parse(Console.ReadLine());
//         //     sum += arr[i];
//         //     aver = (float)sum / arr.Length;
//         // }
//         // Console.WriteLine(aver);

//         // int size;
//         // while (true)
//         // {
//         //     Console.WriteLine("배열 크기를 입력하세요: ");
//         //     if (int.TryParse(Console.ReadLine(), out size) && size > 0)
//         //     {
//         //         break;
//         //     }
//         //     Console.WriteLine("올바른 숫자를 입력하세요.");
//         // }

//         // int[] numbers = new int[size];

//         // for (int i = 0; i < size; i++)
//         // {
//         //     while (true)
//         //     {
//         //         Console.Write($"숫자를 입력하세요 ({i + 1}/{size}): ");
//         //         if (int.TryParse(Console.ReadLine(), out numbers[i]))
//         //         {
//         //             break;
//         //         }
//         //         Console.WriteLine("올바른 숫자를 입력하세요.");
//         //     }
//         // }

//         // int sum = 0;
//         // foreach (int number in numbers)
//         // {
//         //     sum += number;
//         // }

//         // float average = (float)sum / size;
//         // Console.WriteLine($"\n 입력된 숫자들: {string.Join(",", numbers)}");
//         // Console.WriteLine($"총합 : {sum}");
//         // Console.WriteLine($"평균값 : {average}");


//         // int[,] numArr = new int[5, 5];
//         // for (int i = 0; i < 5; i++)
//         // {

//         //     for (int j = 0; j < 5; j++)
//         //     {
//         //         numArr[i, j] = i * 5 + j + 1;
//         //     }

//         // }
//         // for (int i = 0; i < 5; i++)
//         // {

//         //     for (int j = 0; j < 5; j++)
//         //     {
//         //         Console.Write(numArr[i, j]);
//         //     }
//         //     Console.WriteLine();
//         // }
//     }


// }