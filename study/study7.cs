// using System;
// using System.Collections.Generic;
// using System.Data.SqlTypes;
// using System.Diagnostics.CodeAnalysis;
// using System.Linq;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.InteropServices;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.VisualBasic;

// namespace study7
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // //switch 문

//             // int day = 1;

//             // switch(day)
//             // {
//             //     case 1:
//             //         Console.WriteLine("월요일");
//             //         break;
//             //     case 2:
//             //         Console.WriteLine("화요일");
//             //         break;
//             //     case 3:
//             //         Console.WriteLine("수요일");
//             //         break;
//             //     case 4:
//             //         Console.WriteLine("목요일");
//             //         break;
//             //     case 5:
//             //         Console.WriteLine("금요일");
//             //         break;
//             //     default:
//             //         Console.WriteLine("주말입니다.");
//             //         break;
//             // }
//             // int a = 0;
//             // int b = 0;
//             // int c = 0;

//             // int max = a;

//             // if (b > max)
//             //     max = b;
//             // int num;

//             // Console.WriteLine("캐릭터를 선택하세요. (1.검사 2.마법사 3.도적) :");
//             // num = int.Parse(Console.ReadLine()??"");

//             // switch(num)
//             // {
//             //     case 1:
//             //         Console.WriteLine("검사");
//             //         Console.WriteLine("공격력 : 100");
//             //         Console.WriteLine("방어력 : 90");
//             //         return;
//             //     case 2:
//             //         Console.WriteLine("마법사");
//             //         Console.WriteLine("공격력 : 110");
//             //         Console.WriteLine("방어력 : 80");
//             //         return;
//             //     case 3:
//             //         Console.WriteLine("도적적");
//             //         Console.WriteLine("공격력 : 115");
//             //         Console.WriteLine("방어력 : 70");
//             //         return;
//             //     default:
//             //         Console.WriteLine("잘못된 선택입니다.");
//             //         return;
//             // }

//             //초기화 / 조건문 /증감식
//             // for (int i = 0; i <= 5; i++)
//             // {
//             //     Console.WriteLine("숫자 : " + i);
//             // }

//             // for (int i = 0; i < 10; i++)
//             // {
//             //     Console.WriteLine("숫자" + i);
//             // }
//             //    int sum = 0;

//             //     for (int i = 1; i < 11; i++)
//             //     {
//             //         sum += i;
//             //     }
//             //     Console.WriteLine(sum);
//             // int count = 1; 
//             // while(count <= 5)
//             // {
//             //     Console.WriteLine("count : "  + count);

//             //     count++;

//             //     if(count == 3)
//             //     {
//             //         Console.WriteLine("3일때 탈출");
//             //         break;
//             //     }
//             // }

//             //랜덤
//             // Random rand = new Random();
//             // int num = 10;
//             // int randomNumber =0;
//             // for (int i = 0; i < num; i++)
//             // {
//             //     randomNumber = rand.Next(5,15);
//             //     Console.WriteLine("0 이상 10 미만의 랜덤 정수 : " + randomNumber);    
//             // }
//             // //0 이상 10미만의 랜덤 정수
//             // Random rand = new Random();

//             // int randomNumber = 0;

//             // int num = 10;
//             // for (int i = 0; i <= num; i++)
//             // {
//             //     randomNumber = rand.Next(1,101);

//             //     if(randomNumber >= 1 && randomNumber <=10)
//             //     {
//             //         Console.WriteLine("도끼등급 SSS");
//             //     }
//             //     else if(randomNumber >= 11 && randomNumber <=40)
//             //     {
//             //         Console.WriteLine("도끼등급 SS");
//             //     }
//             //     else
//             //     {
//             //         Console.WriteLine("도끼등급 S");
//             //     }
//             //     Thread.Sleep(500);
//             // }

//             // int x =5;

//             // do
//             // {
//             //     Console.WriteLine("최소 한번은 실행 됩니다.");
//             //     x--;

//             // }while (x> 0);

//             // for (int i = 0; i <= 10; i++)
//             // {
//             //     if (i == 5)
//             //     {
//             //         break;
//             //     }

//             //     Console.WriteLine(i);
//             // }

//             // for (int i = 0; i <= 10; i++)
//             // {
//             //     if (i % 2 == 0)
//             //     {
//             //         continue;
//             //     }

//             //     Console.WriteLine(i); //홀수만 출력
//             // }

//             //goto

//             // int n = 1;

//             // start:

//             // if(n <= 5)
//             // {
//             //     Console.WriteLine(n);
//             //     n++;

//             //     goto start;
//             // }

//             Random rand = new Random();

//             Console.WriteLine("대장장이 키우기");
//             int pmoney = 100;
//             int input;
//             int rnd;

//             Thread.Sleep(500);

//             while (true)
//             {
//                 Console.Clear();
//                 Console.WriteLine("1.나무캐기");
//                 Console.WriteLine("2.장비뽑기");
//                 Console.WriteLine("3.나가기");
//                 Console.Write("입력 :");
//                 input = int.Parse(Console.ReadLine() ?? "");

//                 if (input == 1) //나무 캐기씬씬
//                 {
//                     while (true)
//                     {
//                         Console.WriteLine("나무캐기(엔터)");
//                         Console.WriteLine("뒤로가기 x");

//                         string str = Console.ReadLine() ?? "";

//                         pmoney += 100;
//                         Console.WriteLine("소지금 : " + pmoney);
//                         if (str == "x")
//                         {
//                             Console.WriteLine("뒤로가기");
//                             break;
//                         }
//                     }

//                 }
//                 else if (input == 2)
//                 {
//                     //장비뽑기
//                     if (pmoney >= 1000)
//                     {
//                         pmoney -= 1000;

//                         for (int i = 0; i < 20; i++)
//                         {
//                             rnd = rand.Next(1, 101);

//                             if (rnd == 1)
//                             {
//                                 Console.WriteLine("도끼등급 SSS");
//                             }
//                             else if (rnd >= 2 && rnd <= 6)
//                             {
//                                 Console.WriteLine("도끼등급 SS");
//                             }
//                             else if (rnd > 7 && rnd <= 17)
//                             {
//                                 Console.WriteLine("도끼등급 s");
//                             }
//                             else if (rnd >= 18 && rnd <= 38)
//                             {
//                                 Console.WriteLine("도끼 등급 A");
//                             }
//                             else if (rnd >= 39 && rnd <= 69)
//                             {
//                                 Console.WriteLine("도끼등급 B");
//                             }
//                             else
//                             {
//                                 Console.WriteLine("도끼등급 C");
//                             }
//                             Thread.Sleep(500);
//                         }


//                     }
//                     else
//                     {
//                         Console.WriteLine("돈이 부족합니다. \n");
//                         Thread.Sleep(1000);
//                     }

//                 }
//                 else if (input == 3)
//                 {
//                     Console.WriteLine("나갑니다.");
//                     Environment.Exit(0);
//                 }
//             }
//         }

//     }

// }