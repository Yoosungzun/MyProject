// using System;

// class Program
// {

//     static void Main()
//     {
//         Console.WriteLine("몬스터 이름을 작성하세요:");
//         string name = Console.ReadLine();

//         Console.WriteLine("몬스터 체력을 작성하세요 :");
//         int maxHealth = int.Parse(Console.ReadLine());

//         Monster monster = new Monster(name, maxHealth);


//         while (monster.IsAlive())
//         {
//             Console.WriteLine("공격! 데미지를 입력하세요.");
//             int damage = int.Parse(Console.ReadLine());
//             monster.TakeDamage(damage);
//         }

//     }

// }
// struct Monster
// {
//     public string Name;
//     public int Health;
//     public int MaxHealth;

//     public Monster(string name, int maxHealth)
//     {
//         Name = name;
//         MaxHealth = maxHealth;
//         Health = maxHealth;
//     }

//     public void TakeDamage(int damage)
//     {
//         Health -= damage;
//         if (Health <= 0)
//         {
//             Health = 0;
//             Console.WriteLine($"{Name}이(가) 쓰러졌습니다!");
//         }
//         else
//         {
//             Console.WriteLine($"남은체력{Health}");
//         }
//     }

//     public bool IsAlive()
//     {
//         return Health > 0;
//     }
// }
