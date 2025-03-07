// using System;
// using System.Security.Cryptography.X509Certificates;
// class Player
// {
//     protected string Name; //Protected 부모랑 자식 상속관게에서만 사용하고 싶을때

//     public Player()
//     {
//         Name = "플레이어";
//         Console.WriteLine("생성자입니다.");
//     }

//     public void Show()
//     {
//         Console.WriteLine(Name);
//     }
// }

// class Wizard : Player
// {
//     public Wizard()
//     {
//         Name = "마법사";
//         Console.WriteLine("자식 생성자입니다.");
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         // Player p = new Player();
//         // p.Show();

//         // Wizard w = new Wizard();
//         // w.Show();

//         // Wizard w = new Wizard();
//         // Player p = new Wizard();
//         // p.Show(); // 업캐스팅 테스트
//     }
// }