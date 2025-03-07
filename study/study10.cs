// using System;

// namespace study10
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int gold = 0;
//             int depth = 0;
//             int pickaxePower = 1;
//             int combo = 0;
//             int lastDepth = 0;  // 🔹 최종 깊이 저장 변수

//             Random rand = new Random();

//             Console.WriteLine("⛏️ 광산 채굴 시뮬레이터 ⛏️\n");

//             while (true)
//             {
//                 int upgradeCost = 50 * pickaxePower;

//                 // 📌 네모 박스 추가 (현재 깊이 표시)
//                 Console.WriteLine("┌───────────────────┐");
//                 Console.WriteLine($"│                   │");
//                 Console.WriteLine($"│ 최종 깊이: {lastDepth.ToString().PadRight(6)} │"); // 🔹 최종 깊이 표시
//                 Console.WriteLine("└───────────────────┘");

//                 Console.WriteLine($"무엇을 하시겠습니까? 1.채광하기 2.강화하기 금액:{upgradeCost}  3.게임 종료");
//                 Console.WriteLine($"소지금 : {gold}G");
//                 int input = 0;
//                 if (!int.TryParse(Console.ReadLine(), out input)) continue;

//                 switch (input)
//                 {
//                     case 1:
//                         while (true)
//                         {
//                             Console.WriteLine("스페이스바를 눌러 채굴하세요! (Q: 게임 종료)\n");
//                             ConsoleKeyInfo key = Console.ReadKey(true);
//                             if (key.Key == ConsoleKey.Q)
//                             {
//                                 break;
//                             }

//                             if (key.Key == ConsoleKey.Spacebar)
//                             {
//                                 depth += pickaxePower;
//                                 combo++;

//                                 double breakChance = (double)depth / (pickaxePower * 100.0);
//                                 if (rand.NextDouble() < breakChance)
//                                 {
//                                     Console.ForegroundColor = ConsoleColor.Red;
//                                     Console.WriteLine("\n💥 곡괭이가 부서졌습니다! 다시 시작합니다... 💥");
//                                     Console.WriteLine($"최종 깊이: {depth}m 도달 후 부서짐!");
//                                     Console.ResetColor();
//                                     lastDepth = depth; // 🔹 최종 깊이 저장
//                                     pickaxePower = 1;
//                                     depth = 0;
//                                     combo = 0;
//                                     break;
//                                 }

//                                 int roll = rand.Next(100);
//                                 string item;
//                                 int value;

//                                 if (roll < 50) { item = "🪨 돌"; value = 5; }
//                                 else if (roll < 75) { item = "⛏️ 철광석"; value = 20; }
//                                 else if (roll < 90) { item = "💎 보석"; value = 50; }
//                                 else { item = "🌟 전설의 광석"; value = 200; }

//                                 if (combo >= 10)
//                                 {
//                                     combo = 0;
//                                     value *= 2;
//                                     Console.ForegroundColor = ConsoleColor.Yellow;
//                                     Console.WriteLine("✨ 크리티컬 히트! 희귀 광석 획득 ✨");
//                                     Console.ResetColor();
//                                 }

//                                 gold += value;
//                                 Console.WriteLine($"[{depth}m] {item} 발견 ! + {value} 골드(보유: {gold}G)");

//                                 if (depth >= 100 && depth < 200)
//                                 {
//                                     Console.ForegroundColor = ConsoleColor.Red;
//                                     Console.WriteLine("🔥 새로운 지역 발견: 지하 화산! 🔥");
//                                     Console.ResetColor();
//                                 }
//                                 else if (depth >= 200)
//                                 {
//                                     Console.ForegroundColor = ConsoleColor.Magenta;
//                                     Console.WriteLine("👽 새로운 지역 발견: 외계 광산! 👽");
//                                     Console.ResetColor();
//                                 }
//                             }
//                         }
//                         break;
//                     case 2:
//                         if (gold >= upgradeCost)
//                         {
//                             gold -= upgradeCost;
//                             pickaxePower++;
//                             Console.ForegroundColor = ConsoleColor.Cyan;
//                             Console.WriteLine($"⛏️ 곡괭이가 강화되었습니다! (레벨 {pickaxePower})");
//                             Console.ResetColor();
//                         }
//                         else
//                         {
//                             Console.ForegroundColor = ConsoleColor.DarkRed;
//                             Console.WriteLine($"⛏️ 업그레이드 실패! (필요 골드: {upgradeCost}G, 보유 골드: {gold}G)");
//                             Console.ResetColor();
//                         }
//                         break;
//                     case 3:
//                         Console.WriteLine("게임을 종료합니다.");
//                         Environment.Exit(0);
//                         break;
//                     default:
//                         Console.WriteLine("올바른 숫자를 입력하세요.");
//                         break;
//                 }
//             }
//         }
//     }
// }


