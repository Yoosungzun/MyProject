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
//     public virtual void SkillQ(Unit target)
//     {
//         Console.WriteLine($"{Name}이 Q 스킬을 사용 합니다.");
//     }
//     public virtual void SkillW(Unit target)
//     {
//         Console.WriteLine($"{Name}이 W 스킬을 사용  합니다.");
//     }
//     public virtual void SkillE(Unit target)
//     {
//         Console.WriteLine($"{Name}이 E 스킬을 사용  합니다.");
//     }
//     public virtual void SkillR(Unit target)
//     {
//         Console.WriteLine($"{Name}이 R 스킬을 사용  합니다.");
//     }



//     public virtual void Move()
//     {
//         Console.WriteLine($"{Name}이 이동합니다.");
//     }

// }

// //SCV 유닛 (건설과 수리 기능)
// class LeeSin : Unit
// {
//     public LeeSin()
//     {
//         Name = "리신";
//         Health = 200;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("리신이 손과 발을 이용 하여 공격 합니다.");
//     }

//     public override void SkillQ(Unit target)
//     {
//         Console.WriteLine($"{Name}이 {target.Name}을 향해 기를 발사합니다.");
//     }
//     public void SkillQ2(Unit target)
//     {
//         Console.WriteLine($"{Name}이 {target.Name}을 맞춘 적에게 달려갑니다.");
//     }
//     public override void SkillW(Unit target)
//     {
//         Console.WriteLine($"{Name}이 {target.Name}에게 다가가며 보호막을 발생합니다.");
//     }
//     public override void SkillE(Unit target)
//     {
//         Console.WriteLine($"{Name}이 지면을 공격합니다.");
//     }
//     public override void SkillR(Unit target)
//     {
//         Console.WriteLine($"{Name}이 {target.Name}(을)를 강하게 발차기로로 공격합니다.");
//     }


// }

// class Ahri : Unit
// {
//     public Ahri()
//     {
//         Name = "아리";
//         Health = 150;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("작은 기를 발사합니다.");
//     }

//     public override void SkillQ(Unit target)
//     {
//         Console.WriteLine($"{Name}가 커다란 기의 구슬을 {target.Name}에게 던졌다 받습니다");
//     }
//     public override void SkillW(Unit target)
//     {
//         Console.WriteLine($"{Name}가 작은 도깨비 불을 주변에 둡니다.");
//     }
//     public override void SkillE(Unit target)
//     {
//         Console.WriteLine($"{Name}가 {target.Name}(을)를 매혹합니다.");
//     }
//     public override void SkillR(Unit target)
//     {
//         Console.WriteLine($"{Name}가 몸을 기로 감싸 3번 이동 합니다");
//     }


// }

// class Rell : Unit
// {
//     public Rell()
//     {
//         Name = "렐";
//         Health = 600;
//     }

//     public override void Attack()
//     {
//         Console.WriteLine("창을 찌릅니다.");
//     }

//     public override void SkillQ(Unit target)
//     {
//         Console.WriteLine($"{Name}이 창을 내질러 {target.Name}을 기절시킵니다. ");
//     }
//     public override void SkillW(Unit target)
//     {
//         Console.WriteLine($"{Name}이 전방으로 도약후 착지하며 {target.Name}를 모두 띄웁니다.");
//     }
//     public override void SkillE(Unit target)
//     {
//         Console.WriteLine($"{Name}이 이동속도를 증가시킵니다.");
//     }
//     public override void SkillR(Unit target)
//     {
//         Console.WriteLine($"{Name}이 원형 범위에 있는 적을 공중에 띄우면서 모읍니다.");
//     }


// }

// class Program
// {

//     static void Main(string[] args)
//     {
//         List<Unit> units = new List<Unit>();

//         units.Add(new LeeSin());
//         units.Add(new Ahri());
//         units.Add(new Rell());


//         //모든 유닛을 순회하며 다형성 적용
//         foreach (var unit in units)
//         {
//             unit.Move(); //이동
//             unit.Attack(); //공격
//             Console.WriteLine();

//         }

//         //아리가 공격시도
//         Ahri ahri = new Ahri();
//         ahri.SkillW(units[1]);
//         ahri.SkillQ(units[2]);
//         ahri.SkillE(units[0]);

//         //리신이 렐에게 스킬 시도
//         LeeSin leeSin = new LeeSin();

//         leeSin.SkillW(units[2]);

//         //렐이 궁극기 시도
//         Rell rell = new Rell();
//         rell.SkillR(units[1]);
//         Console.WriteLine();
//         ahri.SkillR(units[1]);
//         leeSin.SkillQ(units[1]);
//         ahri.SkillR(units[1]);
//         Console.WriteLine();
//         leeSin.SkillQ2(units[1]);
//         leeSin.SkillE(units[1]);
//         leeSin.SkillE(units[1]);
//         Console.WriteLine();
//         leeSin.SkillR(units[1]);
//         leeSin.SkillQ(units[1]);
//         leeSin.SkillQ2(units[1]);


//     }
// }