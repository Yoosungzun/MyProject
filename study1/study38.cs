// using System;

// class Player
// {
//     public string name;

//     public void Render()
//     {
//         Console.WriteLine("플레이어 " + name);
//     }
// }

// class Wizard : Player
// {
//     public string job;

//     public void Render2()
//     {
//         Console.WriteLine("직업은" + job + "입니다.");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Player p = new Player(); //객체

//         p.name = "홍길동";
//         p.Render();

//         Wizard w = new Wizard();
//         w.name = "대마법사 사우론";
//         w.job = "마법사";

//         w.Render();
//         w.Render2();
//     }
// }