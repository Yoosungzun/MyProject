// using System;
// using System.Collections.Generic;
// using System.Reflection.Metadata;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading;
// using System.Threading.Tasks;

// public class Cross
// {
//     public int crosshairX;
//     public int crosshairY;
//     private Screen screen;
//     private Target target;
//     private Program program;
//     public int bullet;
//     private int maxBullet = 3;
//     public bool isAlive;
//     //숨참기
//     public bool holdBreath;
//     public int holdBreathTime = 3;
//     public bool isHit { get; private set; }
//     public bool wasFired = false;
//     public bool missionSuccess;
//     //십자선 위치
//     public Cross(Screen screen, Target target, Program program)
//     {
//         this.screen = screen;
//         this.target = target;
//         this.program = program;
//         crosshairX = screen.screenWidth / 2;
//         crosshairY = screen.screenHeight / 2;
//         bullet = maxBullet;

//     }

//     //십자선 이미지
//     public void CrossDraw()
//     {
//         string[] cross = new string[]
//         {
//             "┌     ┐",
//             "   +",
//             "└     ┘"
//         };
//         for (int i = 0; i < cross.Length; i++)
//         {
//             Console.SetCursorPosition(crosshairX, crosshairY + i);
//             Console.WriteLine(cross[i]);
//         }


//     }

//     //십자선 이동
//     public void Move(ConsoleKey key)
//     {
//         switch (key)
//         {
//             case ConsoleKey.UpArrow: if (crosshairY > 1) crosshairY--; break;
//             case ConsoleKey.DownArrow: if (crosshairY < screen.screenHeight - 2) crosshairY++; break;
//             case ConsoleKey.LeftArrow: if (crosshairX > 1) crosshairX--; break;
//             case ConsoleKey.RightArrow: if (crosshairX < screen.screenWidth - 6) crosshairX++; break;
//         }
//     }



//     //대상을 맞췄는지 아닌지,방아쇠 트리거
//     public void Fire(ConsoleKey key)
//     {

//         if (bullet > 0)
//         {
//             if (key == ConsoleKey.Spacebar)
//             {
//                 isHit = IsTargetHit();
//                 wasFired = true;
//                 bullet--;
//                 if (isHit == true)
//                 {
//                     program.score += 100;
//                     Thread.Sleep(500);
//                     isAlive = true;
//                     missionSuccess = true;

//                 }

//             }
//         }
//         else
//         {
//             Console.SetCursorPosition(crosshairX - 2, crosshairY + 1);
//             Console.Write("Not enough bullets.");
//             isAlive = true;

//         }



//     }

//     public bool IsTargetHit()
//     {
//         int crossCenterX = crosshairX + 3;
//         int crossCenterY = crosshairY + 1;

//         isHit = (crossCenterX >= target.TargetX - 1 && crossCenterX <= target.TargetX + 1)
//          && (crossCenterY >= target.TargetY && crossCenterY <= target.TargetY + 2);
//         return isHit;
//     }
// }

// public class Screen
// {
//     //화면 사이즈
//     public int screenWidth = 80;
//     public int screenHeight = 20;

//     public void ScreenRender()
//     {

//         Console.Write("┌" + new string('─', screenWidth) + "┐\n");

//         for (int y = 0; y < screenHeight; y++)
//         {
//             Console.Write("│" + new string(' ', screenWidth) + "│\n");
//         }
//         Console.WriteLine("└" + new string('─', screenWidth) + "┘");
//     }


// }

// public class ObjectT
// {
//     private Random random;
//     protected Screen Screen;

//     //시민 위치
//     protected int X;
//     protected int Y;
//     protected int moveSpeed = 1;


//     public ObjectT(Screen Screen)
//     {
//         this.Screen = Screen;
//         random = new Random();
//         ResetPosition();
//     }
//     public void ResetPosition()
//     {
//         X = random.Next(2, Screen.screenWidth - 5);
//         Y = random.Next(2, Screen.screenHeight - 5);
//     }

//     //시민 이미지
//     public virtual void ObjectDraw()
//     {
//         string[] Objects = new string[]
//         {
//             "  ●",
//             "／T＼" ,
//             "／ ＼"
//         };
//         for (int i = 0; i < Objects.Length; i++)
//         {
//             Console.SetCursorPosition(X, Y + i);
//             Console.Write(Objects[i]);
//         }

//     }

//     //타겟 이동 , 시민 이동

//     public void MoveRandom(int chance = 50)
//     {
//         Random random = new Random();
//         int moveChance = random.Next(100);
//         if (moveChance < chance)
//             return;
//         int direction = random.Next(0, 4);
//         switch (direction)
//         {
//             case 0:
//                 if (Y > 1) Y -= moveSpeed;
//                 break;
//             case 1:
//                 if (Y + 2 < Screen.screenHeight) Y += moveSpeed;
//                 break;
//             case 2:
//                 if (X > 1) X -= moveSpeed;
//                 break;
//             case 3:
//                 if (X < Screen.screenWidth) X += moveSpeed;
//                 break;
//         }
//     }

//     public virtual void ObjManager(int x)
//     {
//         MoveRandom(x);
//         ObjectDraw();
//     }

// }

// public class Target : ObjectT
// {
//     public Target(Screen screen) : base(screen) { }
//     public int TargetX;
//     public int TargetY;


//     //타겟 이미지
//     //타겟 위치
//     public override void ObjectDraw()
//     {
//         string[] Objects = new string[]
//         {
//             "  ●",
//             "／T＼",
//             "／ ＼"
//         };

//         for (int i = 0; i < Objects.Length; i++)
//         {
//             Console.SetCursorPosition(X, Y + i);
//             if (i == 0)
//                 Console.ForegroundColor = ConsoleColor.Red;
//             else
//                 Console.ForegroundColor = ConsoleColor.White;
//             Console.Write(Objects[i]);
//         }
//         Console.ResetColor();
//         UpdateTagetPosition();

//     }

//     public void UpdateTagetPosition()
//     {
//         TargetX = X + 2;
//         TargetY = Y;
//     }
//     public override void ObjManager(int x)
//     {
//         MoveRandom(x);
//         ObjectDraw();
//         UpdateTagetPosition();
//     }

// }

// class UI
// {
//     private Cross cross;
//     private Screen screen;
//     private int missX;
//     private int missY;
//     private bool missActive;
//     private int missCounter = 0;
//     private const int maxMissFrames = 30;

//     public int UiWidth = 10;
//     public int levelX = 82;
//     public int levelY = 0;



//     public UI(Cross cross, Screen screen)
//     {
//         this.cross = cross;
//         this.screen = screen;
//     }
//     public void Clear()
//     {
//         if (!cross.wasFired) return;
//         if (cross.isHit)
//         {
//             Console.SetCursorPosition(screen.screenWidth / 2 - 7, screen.screenHeight / 2);
//             Console.Write("Mission Clear!");


//         }
//         else
//         {
//             if (!missActive)
//             {

//                 missX = cross.crosshairX + 3;
//                 missY = cross.crosshairY - 1;
//                 missActive = true;
//             }
//             if (missCounter < maxMissFrames)
//             {
//                 Console.SetCursorPosition(missX, missY);
//                 Console.Write("Miss");
//                 missCounter++;

//             }

//             else
//             {
//                 Console.SetCursorPosition(missX, missY);
//                 Console.Write("");
//                 cross.wasFired = false;
//                 missCounter = 0;
//                 missActive = false;
//             }


//         }
//     }

//     public void Score(Program program)
//     {
//         Console.SetCursorPosition(levelX, levelY + 3);
//         Console.Write("┌" + new string('─', UiWidth) + "┐");

//         int padding = (UiWidth - ("Score " + program.score).Length) / 2;
//         string scoreText = "│" + new string(' ', padding) + "Score  " + program.score + new string(' ', padding) + "│";
//         Console.SetCursorPosition(levelX, levelY + 4);
//         Console.Write(scoreText);

//         Console.SetCursorPosition(levelX, levelY + 5);
//         Console.WriteLine("└" + new string('─', UiWidth) + "┘");
//     }

//     public void LevelUI(Program program)
//     {
//         Console.SetCursorPosition(levelX, levelY);
//         Console.Write("┌" + new string('─', UiWidth) + "┐");

//         int padding = (UiWidth - ("Level " + program.level).Length) / 2;
//         string levelText = "│" + new string(' ', padding) + "Level  " + program.level + new string(' ', padding) + "│";
//         Console.SetCursorPosition(levelX, levelY + 1);
//         Console.Write(levelText);

//         Console.SetCursorPosition(levelX, levelY + 2);
//         Console.WriteLine("└" + new string('─', UiWidth) + "┘");
//     }


//     public async Task<bool> TimeOut()
//     {
//         int timer = 10;
//         while (timer >= 0)
//         {
//             Console.SetCursorPosition(levelX, levelY + 7);
//             Console.Write($"Time : {timer}");
//             await Task.Delay(1000);
//             timer--;

//         }

//         return true;

//     }

//     public void GuideUI()
//     {
//         Console.SetCursorPosition(5, 22);
//         Console.WriteLine("\n[ ← → ] 좌우 조준 | [ ↑ ↓ ] 상하 조준 | [ SPACE ] 발사!");
//     }
//     public void Bullet()
//     {
//         string bullet = "<aaa|]";

//         for (int i = 0; i < cross.bullet; i++)
//         {
//             Console.SetCursorPosition(levelX, levelY + 18 + i);
//             Console.WriteLine(bullet);
//         }

//     }


// }


// public class Program
// {
//     public int level = 1;
//     private int objectCount = 10;
//     public int score = 0;

//     static void Main(string[] args)
//     {
//         Console.CursorVisible = false;

//         Program p = new Program();
//         Screen screen = new Screen();

//         p.Opening(screen);

//         p.StartGame();

//     }

//     public void StartGame()
//     {
//         Screen screen = new Screen();

//         while (true)
//         {

//             bool missionSucess = PlayerLevel(screen);


//             if (missionSucess)
//             {
//                 Console.SetCursorPosition(screen.screenWidth / 2 - 7, screen.screenHeight / 2);
//                 Console.Write("Mission Clear!");
//                 Thread.Sleep(2000); // 2초 대기 후 다음 레벨로 이동
//                 NextLevel();
//             }
//             else
//             {
//                 EndGame(screen);
//                 break;
//             }
//         }
//     }

//     public bool PlayerLevel(Screen screen)
//     {
//         Target target = new Target(screen);
//         List<ObjectT> objectTs = new List<ObjectT>();

//         for (int i = 0; i < objectCount; i++)
//         {
//             objectTs.Add(new ObjectT(screen));
//         }
//         Cross cross = new Cross(screen, target, this);
//         UI ui = new UI(cross, screen);

//         bool timeOut = false;
//         Task.Run(async () =>
//         {
//             timeOut = await ui.TimeOut(); // true 반환 시 게임 종료
//         });

//         while (!cross.isAlive)
//         {
//             Console.Clear();
//             screen.ScreenRender();
//             cross.CrossDraw();

//             ui.LevelUI(this);
//             ui.Score(this);
//             ui.GuideUI();
//             ui.Bullet();

//             if (timeOut)
//             {
//                 return false;
//             }



//             if (Console.KeyAvailable)
//             {
//                 ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//                 cross.Move(keyInfo.Key);
//                 cross.Fire(keyInfo.Key);
//                 ui.Score(this);
//             }

//             target.ObjManager(80);


//             foreach (var obj in objectTs)
//             {
//                 Random random = new Random();
//                 int moveSpeed = random.Next(30, 90);
//                 obj.ObjManager(moveSpeed);
//             }

//             ui.Clear();

//             Thread.Sleep(100);

//         }

//         return cross.missionSuccess;

//     }

//     public void NextLevel()
//     {
//         level++;
//         objectCount += 5;

//     }
//     public void EndGame(Screen screen)
//     {
//         Console.Clear();
//         screen.ScreenRender();
//         int centerX = (screen.screenWidth - "Game Over!!".Length) / 2;
//         int centerY = screen.screenHeight / 2;
//         Console.SetCursorPosition(centerX, centerY);
//         Console.WriteLine("GameOver!!");
//         Console.ReadLine();

//         Console.SetCursorPosition(centerX, centerY + 2);
//         Console.Write("Press any key to exit...");
//         Console.ReadKey(true);
//     }

//     public void Opening(Screen screen)
//     {
//         screen.ScreenRender();
//         string[] title =
//         {
//             "    ___   _  __   __   ___    ___   ___ ",
//             "  ,' _/  / |/ /  / /  / o |  / _/  / o |",
//             " _\\ `.  / || /  / /  / _,'  / _/  /  ,' ",
//             "/___,' /_/|_/  /_/  /_/    /___/ /_/`_\\ "
//         };

//         int centerX = (screen.screenWidth - title[0].Length) / 2;
//         int centerY = screen.screenHeight / 2 - (title.Length / 2);

//         for (int i = 0; i < title.Length; i++)
//         {
//             Console.SetCursorPosition(centerX, centerY + i);
//             Console.WriteLine(title[i]);
//         }

//         Console.SetCursorPosition(centerX + 8, centerY + title.Length + 10);
//         Console.Write("Please insert coin.");
//         Console.ReadKey(true);
//     }



// }