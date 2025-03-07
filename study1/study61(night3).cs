// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // //배열 !!!: Array = "정렬된 것들"
//         // int[] score = { 100, 90, 80 };
//         // string[] name = { "철수", " 영희" , "민수"};

//         // //string <배열이다.
//         // //

//         // Console.WriteLine(score[0]);

//         // int형 정수를 5번 입력 받아서, 1차원 배열에 저장후
//         //배열에 저장된 모든 값의 합을 계산한느 알고리즘
//         // int[] numbers = new int[5];
//         // int sum = 0;

//         // Console.WriteLine("정수 5개 입력해주세요.");
//         // for (int i = 0; i < numbers.Length; i++)
//         // {
//         //     Console.Write($"숫자 {i + 1}:");
//         //     numbers[i] = int.Parse(Console.ReadLine());
//         //     sum += numbers[i];
//         // }
//         // Console.WriteLine(sum);

//         // int[] nums = new int[] { 12, 45, 7, 34, 22 };
//         // int max = nums.Max();
//         // int min = nums.Min();
//         // Console.WriteLine($"최대값 {max}");
//         // Console.WriteLine($"최소값 {min}");

//         // List<int> == int[]
//         // int[] number = new int[길이];
//         // List<int> number = new List<int>();
//         // number.Add(0);

//         // for (int i = 0; i < number.Count; i++)
//         // {

//         // }

//         // List<int> num = new List<int> { 1, 2, 3, 4, 5 };
//         // num.Reverse();

//         // // for (int i = num.Count - 1; i >= 0; i--)
//         // // {
//         // //     Console.WriteLine(num[i]);
//         // // }
//         // num.ForEach((n) => Console.WriteLine(n));
//         // for (int i = 0; i < num.Count; i++)
//         // {
//         //     Console.WriteLine(num[i]);
//         // }

//         //2차원 배열

//         // int[,] array =
//         // {
//         //     {1,2,3,},
//         //     {4,5,6,},
//         //     {7,8,9,}
//         // };

//         // for (int y = 0; y < 3; y++)
//         // {
//         //     for (int x = 0; x < 3; x++)
//         //     {
//         //         Console.Write(array[y, x]);
//         //     }
//         //     Console.WriteLine();
//         // }


//         // int[,] array =
//         // {
//         //     {1,2,3},
//         //     {4,5,6},
//         //     {7,8,9}
//         // };
//         // //각 행과 열의 길이를 받아오는 함수수
//         // int y = array.GetLength(0);
//         // int x = array.GetLength(1);
//         // for (int i = 0; i < y; i++)
//         // {
//         //     int sumX = 0;
//         //     for (int j = 0; j < x; j++)
//         //     {
//         //         sumX += array[i, j];


//         //     }
//         //     Console.WriteLine($"행 :{sumX}");

//         // }
//         // Console.WriteLine($"------------------");

//         // for (int i = 0; i < y; i++)
//         // {
//         //     int sumY = 0;
//         //     for (int j = 0; j < x; j++)
//         //     {

//         //         sumY += array[j, i];

//         //     }

//         //     Console.WriteLine($"열 :{sumY}");
//         // }
//         // int resultX;
//         // int resultY;
//         // int[,] array =
//         // {
//         //     {1,2,3},
//         //     {4,5,6}
//         // };
//         // int y = array.GetLength(0);
//         // int x = array.GetLength(1);
//         // for (int i = 0; i < x; i++)
//         // {
//         //     for (int j = 0; j < y; j++)
//         //     {
//         //         resultX = array[j, i];
//         //         Console.Write($"행:{resultX}");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // for (int i = 0; i < y; i++)
//         // {
//         //     for (int j = 0; j < x; j++)
//         //     {
//         //         resultY = array[i, j];
//         //         Console.Write($"열:{resultY}");
//         //     }
//         //     Console.WriteLine();
//         // }

//         //3x3 빙고게임 대각선을 제외하고 가로세로중 한줄만 완성되면 빙고인걸로

//         int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//         Random random = new Random();

//         for (int i = num.Length - 1; i > 0; i--)
//         {
//             int j = random.Next(0, i + 1);
//             (num[i], num[j]) = (num[j], num[i]);
//         }

//         int[,] num2 = new int[3, 3];
//         int index = 0;

//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 num2[i, j] = num[index++];
//                 Console.Write(num2[i, j] + " ");
//             }
//             Console.WriteLine();
//         }









//     }
// }