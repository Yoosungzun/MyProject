// using System;
// using System.Diagnostics;
// using System.Net.Sockets;
// using System.Threading;

// class Program
// {
//     struct Player
//     {
//         public string[] Shape;
//         public int X;
//         public int Y;

//         public Player(int x, int y)
//         {
//             Shape = new string[]
//             {
//                 "->",
//                 ">>>",
//                 "->",
//             };
//             X = x;
//             Y = y;
//         }

//         public void Move(ConsoleKey key)
//         {
//             switch (key)
//             {
//                 case ConsoleKey.UpArrow: if (Y > 0) Y--; break;
//                 case ConsoleKey.DownArrow: if (Y < Console.WindowHeight - 1) Y++; break;
//                 case ConsoleKey.LeftArrow: if (X > 0) X--; break;
//                 case ConsoleKey.RightArrow: if (X < Console.WindowWidth - 1) X++; break;
//                 case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
//                 case ConsoleKey.Escape: return; //ESC키로 종료 
//             }
//         }

//         public void isPlyaer()
//         {
//             for (int i = 0; i < Shape.Length; i++)
//             {
//                 Console.SetCursorPosition(X, Y + i);
//                 Console.Write(Shape[i]);
//             }
//         }

//     }

//     struct Game
//     {
//         private Player player;
//         private Stopwatch stopwatch;
//         private long prevSecond;

//         public Game()
//         {
//             player = new Player(0, 12);
//             stopwatch = new Stopwatch();
//             prevSecond = 0;
//         }
//         public void Run()
//         {
//             Console.CursorVisible = false;
//             stopwatch.Start();

//             while (true)
//             {
//                 long currentSecond = stopwatch.ElapsedMilliseconds;

//                 if (currentSecond - prevSecond >= 10)
//                 {
//                     Console.Clear();
//                     player.isPlyaer();

//                     if (Console.KeyAvailable)
//                     {
//                         ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//                         player.Move(keyInfo.Key);
//                     }

//                     prevSecond = currentSecond;
//                 }
//             }
//         }
//     }


//     static void Main(string[] args)
//     {
//         Game game = new Game();
//         game.Run();
//     }
// }