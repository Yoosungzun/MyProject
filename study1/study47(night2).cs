// using System;
// using System.Security.Cryptography.X509Certificates;

// class Program
// {
//     static void Main(string[] args)
//     {

//         // for (int i = 2; i < 10; i++)
//         // {
//         //     for (int j = 1; j < 10; j++)
//         //     {
//         //         Console.Write($"{i}x{j}={i * j} \t");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // for (int i = 1; i < 10; i++)
//         // {
//         //     for (int j = 2; j < 10; j++)
//         //     {
//         //         Console.Write($"{j} x {i} = {j * i}\t");
//         //     }
//         //     Console.WriteLine();
//         // }
//         // int x = 0;
//         // while (x <= 5)
//         // {
//         //     Console.WriteLine(x++);
//         // }
//         // int sum = 0;
//         // int x = 1;
//         // while (x < 11)
//         // {
//         //     sum += x;
//         //     x++;
//         // }
//         // Console.WriteLine(sum);

//         // while (true)
//         // {
//         //     Console.WriteLine("1.가위,2.바위,3.보 하나를 선택하세요.:");
//         //     int input = int.Parse(Console.ReadLine());
//         //     string input1 = "";
//         //     try
//         //     {

//         //     }
//         //     catch(Exception)
//         //     {

//         //     }


//         //     switch (input)
//         //     {
//         //         case 1:input1 = "가위";break;
//         //         case 2:input1 = "바위";break;
//         //         case 3:input1 = "보";break;
//         //         default:
//         //             Console.WriteLine("값을 잘못 입력하셨습니다.");
//         //             break;
//         //     }
//         //     Random random = new Random();
//         //     int pc = random.Next(1, 4);
//         //     string pc1 = "";
//         //     switch (pc)
//         //     {
//         //         case 1:
//         //             pc1 = "가위";
//         //             Console.WriteLine("가위");
//         //             break;
//         //         case 2:
//         //             pc1 = "바위";
//         //             Console.WriteLine("바위");
//         //             break;
//         //         case 3:
//         //             pc1 = "보";
//         //             Console.WriteLine("보");
//         //             break;
//         //         default:
//         //             Console.WriteLine("값을 잘못 입력하셨습니다.");
//         //             break;
//         //     }
//         //     string result = "";

//         //     if (input == pc)
//         //     {
//         //         result = "비겼습니다.";
//         //     }
//         //     else if (input + 1 == pc || input - 2 == pc)
//         //     {
//         //         result = "졌습니다.";
//         //     }
//         //     else
//         //     {
//         //         result = "이겼습니다.";

//         //     }


//         //     Console.WriteLine($"{input1}를 내셨습니다. 상대는{pc1}를 냈습니다.{result}");


//         // }

//         Random random = new Random();
//         int Pc = random.Next(1, 101);
//         int input;
//         int inputCount = 0;
//         Console.WriteLine("1에서 100까지 숫자를 입력하세요: ");
//         while (inputCount < 10)
//         {
//             try
//             {
//                 input = int.Parse(Console.ReadLine());

//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("잘못된 글자입니다.");
//                 continue;
//             }

//             if (input == 0) break;
//             if (input < 0 || input > 100) break;
//             inputCount++;

//             if (input == Pc)
//             {
//                 Console.WriteLine("홈런입니다.");
//                 break;
//             }
//             else if (input < Pc)
//             {
//                 Console.WriteLine("틀렸습니다. 더 큰수입니다.");
//             }
//             else
//             {
//                 Console.WriteLine("틀렸습니다. 더 작은수입니다.");
//             }
//         }

//     }
// }