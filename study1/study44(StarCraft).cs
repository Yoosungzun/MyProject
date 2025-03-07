// using System;
// using System.Collections.Generic;

// //부모클래스 (기본유닛)
// class Unit
// {
//     public string Name;
//     protected int Health;

//     public Unit()
//     {
//         Name = "UUnknown";
//         Health = 0;
//     }

//     public virtual void Attack()
//     {
//         Console.WriteLine($"{Name}이 기본 공격을 합니다.");
//     }

//     public virtual void Heal(Unit target)
//     {
//         Console.WriteLine($"{Name}은 치료할 수 없습니다.");
//     }

//     public virtual void Move()
//     {
//         Console.WriteLine($"{Name}이 이동합니다.");
//     }

// }

// //SCV 유닛 (건설과 수리 기능)
// class SCV : Unit
// {
//     public SCV()
//     {
//         Name = "SCV";
//         Health = 60;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("SCV가 용접기로 공격 합니다! (공격력이 약함)");
//     }

//     public override void Heal(Unit target)
//     {
//         Console.WriteLine($"SCV가 {target.Name} 을 수리 합니다.(기계유닛만 가능)");
//     }
// }

// class Marin : Unit
// {
//     public Marin()
//     {
//         Name = "마린";
//         Health = 40;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("마린이 소소총을 사용합니다.");
//     }


// }

// class Medic : Unit
// {
//     public Medic()
//     {
//         Name = "메딕";
//         Health = 50;
//     }

//     public override void Heal(Unit target)
//     {
//         Console.WriteLine($"메딕이 {target.Name}을 치료합니다.(생명유닛만 가능)");
//     }
// }

// class Tank : Unit
// {
//     public Tank()
//     {
//         Name = "Tank";
//         Health = 150;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("Tank가 시즈 모드로 강력한 포격!");
//     }

//     public override void Move()
//     {
//         Console.WriteLine("탱크가 천천히 움직입니다.");
//     }

// }
// class Program
// {

//     static void Main(string[] args)
//     {
//         List<Unit> units = new List<Unit>();

//         units.Add(new SCV());
//         units.Add(new Marin());
//         units.Add(new Medic());
//         units.Add(new Tank());

//         //모든 유닛을 순회하며 다형성 적용
//         foreach (var unit in units)
//         {
//             unit.Move(); //이동
//             unit.Attack(); //공격
//             Console.WriteLine();

//         }

//         //SCV가 탱크 수리 시도
//         SCV scv = new SCV();
//         scv.Heal(units[3]);

//         //Medic이 마린 치료시도
//         Medic medic = new Medic();

//         medic.Heal(units[1]); //마린을 치료
//     }
// }