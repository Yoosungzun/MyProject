// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("무기 이름을 입력하세요:");
//         string name = Console.ReadLine();

//         Console.WriteLine("강화 성공 확률을 입력하세요 (0~100):");
//         int successRate = int.Parse(Console.ReadLine());

//         Weapon weapon = new Weapon(name, successRate);

//         while (weapon.CanEnhance())
//         {
//             Console.WriteLine($"\n 강화 시도! (성공확률 : {weapon.SuccessRate})");
//             Console.WriteLine("강화를 진행하려면 Enter를 누르세요...");
//             Console.ReadLine();
//             weapon.Enhance();
//         }

//     }

//     struct Weapon
//     {
//         public string Name;
//         public int EnhancementLevel;
//         public int SuccessRate;
//         public Weapon(string name, int successRate)
//         {
//             Name = name;
//             EnhancementLevel = 0;
//             SuccessRate = successRate;
//         }

//         public void Enhance()
//         {
//             Random rand = new Random();
//             int chance = rand.Next(1, 101);

//             if (chance <= SuccessRate)
//             {
//                 if (EnhancementLevel < 10)
//                 {
//                     EnhancementLevel++;
//                     Console.WriteLine($"강화 성공! 현재 단계: +{EnhancementLevel}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("이미 최대 강화 단계입니다! (+10)");
//                 }
//             }
//             else
//             {
//                 EnhancementLevel = 0;
//                 Console.WriteLine($"강화가 실패 했습니다.");
//             }
//         }

//         public bool CanEnhance()
//         {
//             return EnhancementLevel < 10;
//         }
//     }


// }