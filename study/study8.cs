// using System;
// using System.Threading;

// namespace study7
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Random rand = new Random();

//             // int gold = 500;
//             // int health = 100;
//             // int power = 10;
//             // int input;
//             // bool isAlive = true;

//             // Console.WriteLine("⚔️모험가 키우기⚔️");
//             // Thread.Sleep(1000);

//             // while (isAlive)

//             // {
//             //     Console.Clear();
//             //     Console.WriteLine($"현재 상태 : 체력 {health} | 골드 {gold} | 공격력 {power}");
//             //     Console.WriteLine("\n1. 탐험하기 🏕️");
//             //     Console.WriteLine("2. 장비 뽑기 🎲 (1000골드)");
//             //     Console.WriteLine("3. 휴식하기 💤(체력 +20)");
//             //     Console.WriteLine("4. 게임 종료");
//             //     Console.Write("입력 : ");
//             //     input = int.Parse(Console.ReadLine() ?? "");

//             //     if (input == 1) // 탐험하기
//             //     {
//             //         Console.Clear();
//             //         Console.WriteLine("탐험을 떠납니다...");
//             //         Thread.Sleep(1000);

//             //         int eventChance = rand.Next(1, 101);

//             //         if (eventChance <= 40) // 40% 확률로 전투 발생
//             //         {
//             //             Console.WriteLine("⚔️ 몬스터와 전투가 시작됩니다!");
//             //             Thread.Sleep(1000);

//             //             int monsterHealth = rand.Next(20, 51); // 몬스터 체력 랜덤 설정 (20~50)
//             //             int monsterPower = rand.Next(5, 16); // 몬스터 공격력 (5~15)
//             //             bool isFighting = true;

//             //             while (isFighting)
//             //             {
//             //                 Console.Clear();
//             //                 Console.WriteLine($"⚔️ 몬스터 체력: {monsterHealth}");
//             //                 Console.WriteLine($"❤️ 내 체력: {health}");
//             //                 Console.WriteLine("\n1. 공격하기 ⚔️");
//             //                 Console.WriteLine("2. 도망가기 🏃");
//             //                 Console.Write("입력 : ");
//             //                 int battleInput = int.Parse(Console.ReadLine() ?? "");

//             //                 if (battleInput == 1) // 공격하기
//             //                 {
//             //                     int damage = rand.Next(power / 2, power + 1);
//             //                     monsterHealth -= damage;
//             //                     Console.WriteLine($"💥 {damage}의 피해를 입혔습니다!");
//             //                     Thread.Sleep(500);

//             //                     if (monsterHealth <= 0)
//             //                     {
//             //                         int reward = rand.Next(100, 301);
//             //                         Console.WriteLine($"🎉 몬스터를 처치했습니다! 💰 +{reward} 골드");
//             //                         gold += reward;
//             //                         isFighting = false;
//             //                         break;
//             //                     }

//             //                     int monsterDamage = rand.Next(monsterPower / 2, monsterPower + 1);
//             //                     health -= monsterDamage;
//             //                     Console.WriteLine($"💀 몬스터가 {monsterDamage}의 피해를 입혔습니다!");
//             //                     Thread.Sleep(500);

//             //                     if (health <= 0)
//             //                     {
//             //                         Console.WriteLine("\n💀 체력이 0이 되어 사망했습니다.");
//             //                         isAlive = false;
//             //                         break;
//             //                     }
//             //                 }
//             //                 else if (battleInput == 2) // 도망가기
//             //                 {
//             //                     Console.WriteLine("🏃 도망쳤습니다! (골드 -50)");
//             //                     gold -= 50;
//             //                     isFighting = false;
//             //                 }
//             //             }
//             //         }
//             //         else if (eventChance <= 70) // 30% 확률로 보상
//             //         {
//             //             int reward = rand.Next(100, 301);
//             //             Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드)");
//             //             gold += reward;
//             //         }
//             //         else // 30% 확률로 회복
//             //         {
//             //             int heal = rand.Next(10, 31);
//             //             Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력)");
//             //             health += heal;
//             //         }

//             //         if (health <= 0)
//             //         {
//             //             Console.WriteLine("\n💀 체력이 0이 되어 사망했습니다.");
//             //             isAlive = false;
//             //         }

//             //         Thread.Sleep(1000);
//             //     }
//             //     else if (input == 2) // 장비뽑기
//             //     {
//             //         if (gold >= 1000)
//             //         {
//             //             gold -= 1000;
//             //             Console.Clear();
//             //             Console.WriteLine("🎲 장비를 뽑습니다.");
//             //             Thread.Sleep(1000);

//             //             for (int i = 0; i < 10; i++)
//             //             {
//             //                 int rnd = rand.Next(1, 101);

//             //                 if (rnd == 1)
//             //                 {
//             //                     Console.WriteLine("✨ SSS급 전설의 검 (공격력 +50) 획득!");
//             //                     power += 50;
//             //                 }
//             //                 else if (rnd <= 10)
//             //                 {
//             //                     Console.WriteLine("🔱 SS급 희귀한 검 (공격력 +30) 획득!");
//             //                     power += 30;
//             //                 }
//             //                 else if (rnd <= 30)
//             //                 {
//             //                     Console.WriteLine("⚔️ S급 강철 검 (공격력 +20) 획득!");
//             //                     power += 20;
//             //                 }
//             //                 else
//             //                 {
//             //                     Console.WriteLine("🗡 녹슨 칼 (공격력 +5) 획득!");
//             //                     power += 5;
//             //                 }
//             //             }

//             //             Thread.Sleep(1000);
//             //         }
//             //         else
//             //         {
//             //             Console.WriteLine("💰 골드가 부족합니다. (1000 골드 필요)");
//             //             Thread.Sleep(1000);
//             //         }
//             //     }
//             //     else if (input == 3) // 휴식하기
//             //     {
//             //         Console.WriteLine("💤 휴식을 취합니다... (+20 체력)");
//             //         health += 20;
//             //         Thread.Sleep(1000);
//             //     }
//             //     else if (input == 4) // 게임 종료
//             //     {
//             //         Console.WriteLine("🎮 게임을 종료합니다. 감사합니다!");
//             //         Environment.Exit(1);
//             //     }
//             //     else
//             //     {
//             //         Console.WriteLine("❌ 잘못된 입력입니다. 다시 선택하세요.");
//             //         Thread.Sleep(1000);
//             //     }
//             // }
//         }
//     }
// }
