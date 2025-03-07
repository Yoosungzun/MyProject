// using System;
// using System.Diagnostics;
// using System.Net.Sockets;
// using System.Threading;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // int x = 10, y = 10;

//         // ConsoleKeyInfo keyInfo;

//         // Console.CursorVisible = false;

//         // while (true)
//         // {
//         //     Console.Clear();

//         //     Console.SetCursorPosition(x, y);

//         //     Console.Write("●"); //현재 위치 출력력

//         //     keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 x)

//         //     //방향키 입력에 따른 좌표 변경
//         //     switch (keyInfo.Key)
//         //     {
//         //         case ConsoleKey.UpArrow: if (y > 0) y--; break;
//         //         case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
//         //         case ConsoleKey.LeftArrow: if (x > 0) x--; break;
//         //         case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
//         //         case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
//         //         case ConsoleKey.Escape: return;//esc키로 종료
//         //     }
//         // }

//         string[] player = new string[]
//         {
//             "->",
//             ">>>",
//             "->",
//         };// 배열 문자열로 그리기

//         int playerX = 0;
//         int playerY = 12;
//         ConsoleKeyInfo keyInfo;

//         Console.CursorVisible = false;

//         //시간 1초 루프
//         Stopwatch stopwatch = new Stopwatch();
//         stopwatch.Start();

//         long prevSecond = stopwatch.ElapsedMilliseconds;

//         while (true)
//         {
//             long currentSecond = stopwatch.ElapsedMilliseconds;//현재 시간 가져오기

//             if (currentSecond - prevSecond >= 10)
//             {
//                 // Console.WriteLine("1초 루프");
//                 Console.Clear();
//                 for (int i = 0; i < player.Length; i++)
//                 {
//                     //콘솔 좌표 설정 플레이어X플레이어 Y
//                     Console.SetCursorPosition(playerX, playerY + i);
//                     //문자열배열 출력
//                     Console.WriteLine(player[i]);
//                 }

//                 if (Console.KeyAvailable) //키가 눌렸을때 true
//                 {
//                     keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
//                                                      //방향키 입력에 따른 좌표 변경
//                     switch (keyInfo.Key)
//                     {
//                         case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
//                         case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
//                         case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
//                         case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
//                         case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
//                         case ConsoleKey.Escape: return; //ESC키로 종료 

//                     }

//                 }




//                 prevSecond = currentSecond; //이전 시간 업데이트트
//             }


//         }

//     }
// }