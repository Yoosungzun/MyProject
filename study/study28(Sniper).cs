// using System;
// using System.Collections.Generic;

// using System.Threading;
// //스나이퍼 게임
// //타겟이랑 시민이 돌아다니고 있어
// //1인칭 조준점을 이용해서 타겟을 제거해야돼.
// //라운드가 지나갈때마다 시민이 늘고 장애물이 많아지는 게임.
// //평소는 숨쉬는 기능때문에 조준점이 흔들린다.
// //숨참는 버튼(쉬프트키)누르면 조준점이 흔들리지 않는다.다만 게이지까지만(3초)
// //타이머가 있어서 그 시간 안까지 타겟을 제거 
// //타겟은 시민뒤에 숨거나 장애물 뒤에 숨을 수 있음.
// //방아쇠를 당기는 버튼은 스페이스바.


// class SniperGame
// {
//     static int screenWidth = 30;
//     static int screenHeight = 10;
//     static int crosshairX = screenWidth / 2;  // 조준점 X 위치
//     static int crosshairY = screenHeight / 2; // 조준점 Y 위치 (상하 조준 추가)
//     static int targetX;
//     static int targetHeadY;
//     static int targetBodyY;
//     static int civilianX;
//     static int civilianHeadY;
//     static int civilianBodyY;
//     static bool gameOver = false;
//     static bool holdingBreath = false;
//     static int breathTimer = 3; // 숨참기 지속시간 (초)
//     static int round = 1;
//     static Random rand = new Random();
//     static List<int> obstacles = new List<int>();
//     static int timeLimit = 20;
//     static DateTime roundStartTime;
//     static int breathCycle = 0;
//     static int civilianMoveCycle = 0; // 시민 이동 속도 조절 변수
//     static int targetMoveCycle = 0;   // 타겟 이동 속도 조절 변수

//     static void Main()
//     {
//         Console.CursorVisible = false;
//         InitializeGame();
//         GameLoop();
//     }

//     static void InitializeGame()
//     {
//         InitializeTargets();
//         roundStartTime = DateTime.Now;
//     }

//     static void InitializeTargets()
//     {
//         targetX = rand.Next(2, screenWidth - 2);
//         targetHeadY = screenHeight / 2 - 1;
//         targetBodyY = screenHeight / 2 + 1;

//         civilianX = rand.Next(2, screenWidth - 2);
//         civilianHeadY = screenHeight / 2 - 1;
//         civilianBodyY = screenHeight / 2 + 1;

//         while (civilianX == targetX)
//             civilianX = rand.Next(2, screenWidth - 2);

//         obstacles.Clear();
//         for (int i = 0; i < round * 2; i++)
//         {
//             int obstaclePos = rand.Next(2, screenWidth - 2);
//             if (obstaclePos != targetX && obstaclePos != civilianX)
//                 obstacles.Add(obstaclePos);
//         }
//     }

//     static void GameLoop()
//     {
//         while (!gameOver)
//         {
//             Render();
//             HandleInput();
//             MoveEntities();
//             CheckTimeLimit();
//             Thread.Sleep(300);
//         }
//     }

//     static void Render()
//     {
//         Console.Clear();
//         Console.WriteLine("┌" + new string('─', screenWidth) + "┐");

//         for (int y = 0; y < screenHeight; y++)
//         {
//             Console.Write("│");

//             for (int x = 0; x < screenWidth; x++)
//             {
//                 if (x == crosshairX && y == crosshairY)
//                 {
//                     Console.ForegroundColor = ConsoleColor.White;
//                     Console.Write("+"); // 조준점 중앙
//                 }
//                 else if ((x == crosshairX - 1 || x == crosshairX + 1) && (y == crosshairY - 1 || y == crosshairY + 1))
//                 {
//                     Console.ForegroundColor = ConsoleColor.DarkGray;
//                     Console.Write("┌"); // 크로스헤어 모서리
//                 }
//                 else if (x == targetX && y == targetHeadY) // 타겟 머리
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.Write("●");
//                 }
//                 else if (x == targetX && y == targetBodyY) // 타겟 몸통
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.Write("T");
//                 }
//                 else if (x == civilianX && y == civilianHeadY) // 시민 머리
//                 {
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.Write("●");
//                 }
//                 else if (x == civilianX && y == civilianBodyY) // 시민 몸통
//                 {
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.Write("C");
//                 }
//                 else if (obstacles.Contains(x) && y == screenHeight / 2 + 2) // 장애물
//                 {
//                     Console.ForegroundColor = ConsoleColor.DarkGray;
//                     Console.Write("X");
//                 }
//                 else Console.Write(" ");
//             }

//             Console.ResetColor();
//             Console.WriteLine("│");
//         }


//         Console.WriteLine("└" + new string('─', screenWidth) + "┘");
//         Console.WriteLine("\n[ ← → ] 좌우 조준 | [ ↑ ↓ ] 상하 조준 | [ SHIFT ] 숨참기 | [ SPACE ] 발사!");
//         Console.WriteLine($"🎯 현재 라운드: {round} | 장애물 수: {obstacles.Count}");
//         Console.WriteLine($"⏳ 남은 시간: {Math.Max(0, timeLimit - (int)(DateTime.Now - roundStartTime).TotalSeconds)}초");
//         Console.WriteLine($"💨 숨참기 게이지: {breathTimer}초");
//     }

//     static void HandleInput()
//     {
//         if (!Console.KeyAvailable) return;

//         ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//         switch (keyInfo.Key)
//         {
//             case ConsoleKey.LeftArrow:
//                 if (crosshairX > 1) crosshairX--;
//                 break;
//             case ConsoleKey.RightArrow:
//                 if (crosshairX < screenWidth - 2) crosshairX++;
//                 break;
//             case ConsoleKey.UpArrow:
//                 if (crosshairY > 1) crosshairY--;
//                 break;
//             case ConsoleKey.DownArrow:
//                 if (crosshairY < screenHeight - 2) crosshairY++;
//                 break;
//             case ConsoleKey.Spacebar:
//                 FireGun();
//                 break;
//         }

//         if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
//         {
//             if (breathTimer > 0) holdingBreath = !holdingBreath;
//         }
//     }

//     static void MoveEntities()
//     {
//         if (!holdingBreath) // 숨참기 상태가 아닐 때만 진동
//         {
//             if (breathCycle % 5 == 0) // 숨쉬기 간격 조정
//             {
//                 if (rand.Next(100) < 20) // 20% 확률로 흔들리게 함
//                 {
//                     crosshairX += rand.Next(-1, 2);
//                     crosshairY += rand.Next(-1, 2);
//                     crosshairX = Math.Max(1, Math.Min(screenWidth - 2, crosshairX));
//                     crosshairY = Math.Max(1, Math.Min(screenHeight - 2, crosshairY));
//                 }
//             }
//             breathCycle++;
//         }
//         else
//         {
//             // 🔹 숨참기 중일 때는 조준점 고정
//             breathTimer--;
//             if (breathTimer <= 0)
//             {
//                 holdingBreath = false; // 숨참기 끝나면 다시 흔들리기 시작
//                 breathTimer = 3; // 숨참기 게이지 초기화
//             }
//         }

//         // 시민 이동 속도 조절
//         if (civilianMoveCycle % 10 == 0)
//         {
//             civilianX += rand.Next(-1, 2);
//             civilianX = Math.Max(1, Math.Min(screenWidth - 2, civilianX));
//         }
//         civilianMoveCycle++;

//         // 타겟 이동 속도 조절
//         if (targetMoveCycle % 20 == 0)
//         {
//             targetX += rand.Next(-1, 2);
//             targetX = Math.Max(1, Math.Min(screenWidth - 2, targetX));
//         }
//         targetMoveCycle++;
//     }

//     static void CheckTimeLimit()
//     {
//         if ((DateTime.Now - roundStartTime).TotalSeconds >= timeLimit)
//         {
//             Console.Clear();
//             Console.WriteLine("⏳ 시간 초과! 임무 실패!");
//             gameOver = true;
//             Thread.Sleep(2000);
//         }
//     }

//     static void FireGun()
//     {
//         Console.Clear();
//         Console.WriteLine(" 방아쇠를 당겼다...");
//         Thread.Sleep(1000);

//         if (crosshairX == targetX)
//         {
//             Console.WriteLine(" 헤드샷 성공! 다음 라운드!");
//             round++;
//             InitializeTargets();
//         }
//         else if (crosshairX == civilianX)
//         {
//             Console.WriteLine(" 시민 사살! 게임 오버!");
//             gameOver = true;
//         }
//         else
//         {
//             Console.WriteLine(" 빗나갔다! 타겟이 도망쳤다...");
//         }

//         Thread.Sleep(2000);
//     }
// }
