// using System;
// using System.Diagnostics.CodeAnalysis;
// using System.IO;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         // int num;

//         // num = int.Parse(Console.ReadLine());

//         // if (num <= 100)
//         // {
//         //     Console.WriteLine("레벨업");
//         // }
//         // else
//         // {
//         //     Console.WriteLine();
//         // }

//         // int age = int.Parse(Console.ReadLine());
//         // if (age < 13) Console.WriteLine("어린이");
//         // else if (age < 19) Console.WriteLine("청소년");
//         // else Console.WriteLine("성인");

//         // string grade = Console.ReadLine();
//         // switch (grade)
//         // {
//         //     case "A": Console.WriteLine("최고"); break;
//         //     case "B": Console.WriteLine("좋음음"); break;
//         //     case "C": Console.WriteLine("보통통"); break;
//         //     case "D": Console.WriteLine("탈락락"); break;
//         // }

//         // int month = int.Parse(Console.ReadLine());
//         // switch (month)
//         // {
//         //     case 12:
//         //     case 1:
//         //     case 2: Console.WriteLine("겨울"); break;
//         //     case 3:
//         //     case 4:
//         //     case 5: Console.WriteLine("봄"); break;
//         //     case 6:
//         //     case 7:
//         //     case 8: Console.WriteLine("여름"); break;
//         //     case 9:
//         //     case 10:
//         //     case 11: Console.WriteLine("가을"); break;
//         //     default: Console.WriteLine("잘못 입력되었습니다."); break;
//         // }

//         // int season = int.Parse(Console.ReadLine());
//         // if (season >= 12 && season < 3) Console.WriteLine("겨울");
//         // else if (season >= 3 && season < 6) Console.WriteLine("봄봄");
//         // else if (season >= 6 && season < 9) Console.WriteLine("여름름");
//         // else if (season >= 9 && season < 12) Console.WriteLine("가을을");
//         // else Console.WriteLine("잘못 입력 되었습니다.");

//         //반복문

//         // for (int i = 0; i < 5; i++)
//         // {
//         //     Console.WriteLine($"몬스터 소환 {i+1} 번째");
//         // }

//         // for (int i = 1; i < 11; i++)
//         // {
//         //     Console.WriteLine($"숫자 : {i}");
//         // }

//         // int sum = 0;

//         // for (int i = 1; i <= 10; i++)
//         // {
//         //     sum += i;

//         // }
//         // Console.WriteLine(sum);

//         // int num = int.Parse(Console.ReadLine());
//         // for (int i = 1; i < 10; i++)
//         // {
//         //     Console.WriteLine($"{num} * {i} = {num * i}");
//         // }


//         // for (int i = 0; i < 6; i++)
//         // {
//         //     for (int j = 0; j < i; j++)
//         //     {
//         //         Console.Write("*");

//         //     }
//         //     Console.WriteLine();
//         // }

//         // string s = "*";

//         // for (int i = 0; i < 4; i++)
//         // {
//         //     Console.WriteLine(s);

//         //     s += "*";
//         // }
//         // int h = 3;
//         // for (int i = h; i >= 1; i--)
//         // {
//         //     for (int j = 0; j < i; j++)
//         //     {
//         //         Console.Write("*");
//         //     }
//         //     Console.WriteLine();
//         // }
//         // int num = 1;
//         // int h = 5;
//         // for (int i = 0; i < h; i++)
//         // {
//         //     for (int j = 0; j < i; j++)
//         //     {

//         //         Console.Write(num);
//         //         num++;
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int num = 1;
//         // int h = 6;
//         // for (int i = 0; i < h; i++)
//         // {
//         //     for (int j = 0; j < i; j++)
//         //     {
//         //         Console.Write($"{num} ");
//         //         num++;
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int size = 8;
//         // for (int i = 0; i < size; i++)
//         // {
//         //     for (int j = 0; j < size; j++)
//         //     {
//         //         Console.Write((i + j) % 2 == 0 ? "#" : ".");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int size = 5;
//         // Func<int, int, string> get = (i, j) => (i + j) % 2 == 0 ? "#" : ".";
//         // for (int i = 0; i < size; i++)
//         // {
//         //     for (int j = 0; j < size; j++)
//         //     {
//         //         Console.Write(get(i, j));
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int size = 5;
//         // for (int i = 0; i < size; i++)
//         // {
//         //     for (int j = 0; j < size; j++)
//         //     {
//         //         if ((i + j) % 2 == 0)
//         //         {
//         //             Console.Write("#");
//         //         }
//         //         else
//         //         {
//         //             Console.Write(".");
//         //         }
//         //     }
//         //     Console.WriteLine();
//         // }
//         // int n = 5; // 마름모 높이 (중앙 기준)

//         // // 위쪽 삼각형
//         // for (int i = 1; i <= n; i++)
//         // {
//         //     for (int j = i; j < n; j++) // 공백 출력
//         //     {
//         //         Console.Write(" ");
//         //     }
//         //     for (int j = 1; j <= (2 * i - 1); j++) // 별 출력
//         //     {
//         //         Console.Write("*");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // // 아래쪽 역삼각형
//         // for (int i = n - 1; i >= 1; i--)
//         // {
//         //     for (int j = n; j > i; j--) // 공백 출력
//         //     {
//         //         Console.Write(" ");
//         //     }
//         //     for (int j = 1; j <= (2 * i - 1); j++) // 별 출력
//         //     {
//         //         Console.Write("*");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int enemyCount = 5;
//         // Random random = new Random();

//         // for (int i = 0; i < enemyCount; i++)
//         // {
//         //     int x = random.Next(100);
//         //     int y = random.Next(100);

//         //     Console.WriteLine($"Enemy {i + 1}: 위치 ({x},{y})에서 생성됨");
//         // }

//         // int level = 1;
//         // int exp = 0;
//         // int maxExp = 100;

//         // for (int i = 0; i < 10; i++)
//         // {
//         //     exp += 30;
//         //     Console.WriteLine($"전투 {i + 1}: 현재 경험치 {exp}/{maxExp}");
//         //     if (exp >= maxExp)
//         //     {
//         //         level++;
//         //         exp -= maxExp;
//         //         maxExp += 50;
//         //         Console.WriteLine($"레벨업! 현재 레벨: {level}, 새로운 경험치 필요량:{maxExp} ");
//         //     }
//         // }

//         // int level = 1;
//         // int exp = 0;
//         // int maxExp = 100;
//         // for (int i = 0; i < 10; i++)
//         // {
//         //     exp += 30;
//         //     Console.WriteLine($"전투 {i + 1} :현재 경험치 {exp}/{maxExp}");
//         //     if (exp >= maxExp)
//         //     {
//         //         level++;
//         //         exp -= maxExp;
//         //         maxExp += 50;
//         //         Console.WriteLine($"레벨업! 현재 레벨:{level} ,새로운 경험치 필요량: {maxExp}");
//         //     }
//         // }

//         // int startX = 0;
//         // int endX = 10;

//         // for (int x = startX; x <= endX; x++)
//         // {
//         //     Console.Clear();
//         //     Console.SetCursorPosition(x, 5);
//         //     Console.Write("P");
//         //     Thread.Sleep(300);
//         // }

//         string[] items = { "일반 아이템", "희귀 아이템", "전설 아이템" };
//         int[] dorpRates = { 80, 15, 5 };

//         Random random = new Random();

//         for (int i = 0; i < 10; i++)
//         {
//             int roll = random.Next(101);
//             string droppedItem = "아이템 없음";

//             if (roll <= dorpRates[2])
//                 droppedItem = items[2];
//             else if (roll <= dorpRates[2] + dorpRates[1])
//                 droppedItem = items[1];
//             else
//                 droppedItem = items[0];

//             Console.WriteLine($"전투 {i + 1} : {droppedItem}");
//         }
//     }
// }