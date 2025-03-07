// using System;
// using System.Runtime.InteropServices;
// using System.Security.AccessControl;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading;



// //미사일 클래스
// public class BULLET
// {
//     public int x;
//     public int y;
//     public bool fire;

// }

// //플레이어 클래스
// public class Player
// {
//     [DllImport("msvcrt.dll")]
//     static extern int _getch();  //c언어 함수 가져옴

//     public int playerX; //플레이어 x좌표
//     public int playerY; //플레이어 y좌표
//     public BULLET[] plyaerBullet = new BULLET[20];
//     public BULLET[] plyaerBullet2 = new BULLET[20];
//     public BULLET[] plyaerBullet3 = new BULLET[20];
//     public int Score = 100;
//     public Item item = new Item();
//     public int iteCount = 0;

//     public Player() //생성자
//     {
//         //플레이어 좌표 위치초기화
//         playerX = 0;
//         playerY = 12;


//         for (int i = 0; i < 20; i++)//총알 초기화화
//         {
//             plyaerBullet[i] = new BULLET();
//             plyaerBullet[i].x = 0;
//             plyaerBullet[i].y = 0;
//             plyaerBullet[i].fire = false;

//             plyaerBullet2[i] = new BULLET();
//             plyaerBullet2[i].x = 0;
//             plyaerBullet2[i].y = 0;
//             plyaerBullet2[i].fire = false;

//             plyaerBullet3[i] = new BULLET();
//             plyaerBullet3[i].x = 0;
//             plyaerBullet3[i].y = 0;
//             plyaerBullet3[i].fire = false;
//         }
//     }

//     public void GameMain()
//     {
//         //키를 입력하는 부분
//         keyControl();

//         //플레이어를 그려준다.
//         PlayerDraw();

//         UIScore();

//         if (item.ItemLife)
//         {
//             item.ItemMove();
//             item.ItemDraw();
//             CrashItem();
//         }
//     }



//     public void keyControl()
//     {
//         // int pressKey; //정수형 변수선언 키값 받을거임
//         if (Console.KeyAvailable) //키가 눌렸을때 true
//         {
//             // pressKey = _getch(); //아스키값 왼쪽 오른쪽
//             ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//             switch (keyInfo.Key)
//             {
//                 case ConsoleKey.UpArrow:
//                     playerY = Math.Max(1, playerY - 1);
//                     break;
//                 case ConsoleKey.DownArrow:
//                     playerY = Math.Min(Console.WindowHeight - 2, playerY + 1);
//                     break;
//                 case ConsoleKey.LeftArrow:
//                     playerX = Math.Max(1, playerX - 1);
//                     break;
//                 case ConsoleKey.RightArrow:
//                     playerX = Math.Min(Console.WindowWidth - 4, playerX + 1);
//                     break;

//                 case ConsoleKey.Spacebar://스페이스바
//                     //총알 발사
//                     for (int i = 0; i < 20; i++)
//                     {
//                         //미사일이 false 발사 가능
//                         if (plyaerBullet[i].fire == false)
//                         {
//                             plyaerBullet[i].fire = true;
//                             //플레이어 앞에서 미사일 쏘기 +5
//                             plyaerBullet[i].x = playerX + 3;
//                             plyaerBullet[i].y = playerY + 1;
//                             //한발씩 쏘겠다.
//                             break;
//                         }
//                     }
//                     for (int i = 0; i < 20; i++)
//                     {
//                         //미사일이 false 발사 가능
//                         if (plyaerBullet2[i].fire == false)
//                         {
//                             plyaerBullet2[i].fire = true;
//                             //플레이어 앞에서 미사일 쏘기 +5
//                             plyaerBullet2[i].x = playerX + 3;
//                             plyaerBullet2[i].y = playerY + 0;
//                             //한발씩 쏘겠다.
//                             break;
//                         }
//                     }
//                     for (int i = 0; i < 20; i++)
//                     {
//                         //미사일이 false 발사 가능
//                         if (plyaerBullet3[i].fire == false)
//                         {
//                             plyaerBullet3[i].fire = true;
//                             //플레이어 앞에서 미사일 쏘기 +5
//                             plyaerBullet3[i].x = playerX + 3;
//                             plyaerBullet3[i].y = playerY + 2;
//                             //한발씩 쏘겠다.
//                             break;
//                         }
//                     }
//                     break;


//             }
//             Thread.Sleep(5);
//         }
//     }

//     //미사일 그리기
//     public void BulletDraw()
//     {
//         string bullet = "->";//미사일 모습

//         //20개
//         for (int i = 0; i < 20; i++)
//         {
//             //미사일이 살아있는 상태
//             if (plyaerBullet[i].fire == true)
//             {
//                 if (plyaerBullet[i].y >= 0 && plyaerBullet[i].y < Console.BufferHeight) // y 범위 체크
//                 {
//                     //좌표 설정 -> 중간위치를 위해 보정을 x -1
//                     Console.SetCursorPosition(plyaerBullet[i].x - 1, plyaerBullet[i].y);
//                     //총알 출력
//                     Console.Write(bullet);
//                 }

//                 plyaerBullet[i].x++; //미사일 오르쪽으로 날라가기기

//                 if (plyaerBullet[i].x > Console.BufferWidth - 1)
//                 {
//                     plyaerBullet[i].fire = false; //미사일 false다시 준비상태태
//                 }
//             }
//         }
//     }
//     public void BulletDraw2()
//     {
//         string bullet = "->";//미사일 모습

//         //20개
//         for (int i = 0; i < 20; i++)
//         {
//             //미사일이 살아있는 상태
//             if (plyaerBullet2[i].fire == true)
//             {
//                 if (plyaerBullet2[i].y >= 0 && plyaerBullet2[i].y < Console.BufferHeight) // y 범위 체크
//                 {
//                     //좌표 설정 -> 중간위치를 위해 보정을 x -1
//                     Console.SetCursorPosition(plyaerBullet2[i].x - 1, plyaerBullet2[i].y);
//                     //총알 출력
//                     Console.Write(bullet);
//                 }

//                 plyaerBullet2[i].x++; //미사일 오르쪽으로 날라가기기

//                 if (plyaerBullet2[i].x > Console.BufferWidth - 1)
//                 {
//                     plyaerBullet2[i].fire = false; //미사일 false다시 준비상태태
//                 }
//             }
//         }
//     }
//     public void BulletDraw3()
//     {
//         string bullet = "->";//미사일 모습

//         //20개
//         for (int i = 0; i < 20; i++)
//         {
//             //미사일이 살아있는 상태
//             if (plyaerBullet3[i].fire == true)
//             {
//                 if (plyaerBullet3[i].y >= 0 && plyaerBullet3[i].y < Console.BufferHeight) // y 범위 체크
//                 {
//                     //좌표 설정 -> 중간위치를 위해 보정을 x -1
//                     Console.SetCursorPosition(plyaerBullet3[i].x - 1, plyaerBullet3[i].y);
//                     //총알 출력
//                     Console.Write(bullet);
//                 }

//                 plyaerBullet3[i].x++; //미사일 오르쪽으로 날라가기기

//                 if (plyaerBullet3[i].x > Console.BufferWidth - 1)
//                 {
//                     plyaerBullet3[i].fire = false; //미사일 false다시 준비상태태
//                 }
//             }
//         }
//     }

//     public void PlayerDraw()
//     {
//         String[] plyaer = new string[]
//         {
//             "->",
//             ">>>",
//             "->"
//             //배열로 문자열로 그리기
//         };

//         for (int i = 0; i < plyaer.Length; i++)
//         {
//             int newY = playerY + i;
//             if (newY >= Console.BufferHeight) // 콘솔 크기 체크
//                 newY = Console.BufferHeight - 1;
//             //콘솔좌표 설정 플레이어 x 플레이어 y
//             Console.SetCursorPosition(playerX, newY);
//             //문자열배열 출력
//             Console.WriteLine(plyaer[i]);
//         }
//     }
//     //충돌처리
//     public void ClashEnemyAndBullet(Enemy enemy)
//     {
//         //미사일 20
//         for (int i = 0; i < 20; i++)
//         {
//             //살아있는 미사일
//             if (plyaerBullet[i].fire == true)
//             {
//                 //미사일과 적의 y값이 같을때
//                 if (plyaerBullet[i].y == enemy.enemyY)
//                 {
//                     if (plyaerBullet[i].x >= (enemy.enemyX - 1) && plyaerBullet[i].x >= (enemy.enemyX + 1))//여유둬서 충돌좌표
//                     {
//                         //충돌
//                         item.ItemLife = true;
//                         item.itmeX = enemy.enemyX;
//                         item.itemY = enemy.enemyY;

//                         Random random = new Random();
//                         enemy.enemyX = Console.BufferWidth - 2;
//                         enemy.enemyY = random.Next(2, Console.BufferHeight - 2);

//                         plyaerBullet[i].fire = false; //미사일도 준비 상태로 만들어 두기기

//                         //스코어
//                         Score += 100;

//                     }
//                 }

//             }
//         }
//         //미사일 20
//         for (int i = 0; i < 20; i++)
//         {
//             //살아있는 미사일
//             if (plyaerBullet2[i].fire == true)
//             {
//                 //미사일과 적의 y값이 같을때
//                 if (plyaerBullet2[i].y == enemy.enemyY)
//                 {
//                     if (plyaerBullet2[i].x >= (enemy.enemyX - 1) && plyaerBullet2[i].x >= (enemy.enemyX + 1))//여유둬서 충돌좌표
//                     {
//                         //충돌
//                         item.ItemLife = true;
//                         item.itmeX = enemy.enemyX;
//                         item.itemY = enemy.enemyY;

//                         Random random = new Random();
//                         enemy.enemyX = Console.BufferWidth - 2;
//                         enemy.enemyY = random.Next(2, Console.BufferHeight - 2);

//                         plyaerBullet2[i].fire = false; //미사일도 준비 상태로 만들어 두기기

//                         //스코어
//                         Score += 100;

//                     }
//                 }

//             }
//         }
//         //미사일 20
//         for (int i = 0; i < 20; i++)
//         {
//             //살아있는 미사일
//             if (plyaerBullet3[i].fire == true)
//             {
//                 //미사일과 적의 y값이 같을때
//                 if (plyaerBullet3[i].y == enemy.enemyY)
//                 {
//                     if (plyaerBullet3[i].x >= (enemy.enemyX - 1) && plyaerBullet3[i].x >= (enemy.enemyX + 1))//여유둬서 충돌좌표
//                     {
//                         //충돌
//                         item.ItemLife = true;
//                         item.itmeX = enemy.enemyX;
//                         item.itemY = enemy.enemyY;

//                         Random random = new Random();
//                         enemy.enemyX = Console.BufferWidth - 2;
//                         enemy.enemyY = random.Next(2, Console.BufferHeight - 2);

//                         plyaerBullet3[i].fire = false; //미사일도 준비 상태로 만들어 두기기

//                         //스코어
//                         Score += 100;

//                     }
//                 }

//             }
//         }
//     }
//     public void UIScore()
//     {
//         int scoreX = Console.BufferWidth - 20; // 점수를 오른쪽 끝에 위치하도록 조정
//         int scoreY = 0; // 최상단

//         Console.SetCursorPosition(scoreX, scoreY);
//         Console.Write("┏━━━━━━━━━━━━━━┓");

//         Console.SetCursorPosition(scoreX, scoreY + 1);
//         Console.Write("┃              ┃");

//         Console.SetCursorPosition(scoreX + 2, scoreY + 1); // 텍스트 중앙 정렬
//         Console.Write("Score : " + Score);

//         Console.SetCursorPosition(scoreX, scoreY + 2);
//         Console.Write("┗━━━━━━━━━━━━━━┛");
//     }


//     //아이템 충돌이 일어나면 양쪽미사일 발사
//     public void CrashItem()
//     {
//         if (playerY + 1 == item.itemY)
//         {
//             if (playerX >= item.itmeX - 2 && playerX >= item.itmeX + 2)
//             {
//                 item.ItemLife = false;

//                 if (iteCount < 3)
//                     iteCount++;

//                 for (int i = 0; i < 20; i++)
//                 {
//                     plyaerBullet[i] = new BULLET();
//                     plyaerBullet[i].x = 0;
//                     plyaerBullet[i].y = 0;
//                     plyaerBullet[i].fire = false;

//                     plyaerBullet2[i] = new BULLET();
//                     plyaerBullet2[i].x = 0;
//                     plyaerBullet2[i].y = 0;
//                     plyaerBullet2[i].fire = false;

//                     plyaerBullet3[i] = new BULLET();
//                     plyaerBullet3[i].x = 0;
//                     plyaerBullet3[i].y = 0;
//                     plyaerBullet3[i].fire = false;
//                 }

//             }
//         }
//     }


// }



// public class Enemy
// {
//     public int enemyX; //x 좌표
//     public int enemyY; //u 좌표표

//     public Enemy()
//     {
//         //적 좌표 초기화
//         enemyX = 77;
//         enemyY = 12;
//     }

//     public void EnemyDraw()//적그리기기
//     {
//         string enemy = "<-0->"; //문자열로 표현
//         Console.SetCursorPosition(enemyX, enemyY); //좌표설정
//         Console.Write(enemy);//출력력

//     }

//     public void EnemyMove()
//     {
//         Random rand = new Random(); //랜덤
//         enemyX--; //왼쪽으로 움직임

//         if (enemyX < 2)//화면 왼쪽넘어가면 새로 좌표 잡아라
//         {
//             enemyX = Console.BufferWidth - 1;
//             enemyY = rand.Next(2, Console.BufferHeight - 2);
//         }
//     }



// }

// //아이템 클래스
// public class Item
// {
//     public string ItemName;
//     public string ItemSprite;
//     public int itmeX = 0;
//     public int itemY = 0;
//     public bool ItemLife = false;

//     public void ItemDraw()
//     {
//         Console.SetCursorPosition(itmeX, itemY);
//         ItemSprite = "Item★";
//         Console.Write(ItemSprite);
//     }

//     public void ItemMove()
//     {
//         if (itmeX <= 1 || itemY <= 1)
//         {
//             ItemLife = false;
//         }


//     }

// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         Console.CursorVisible = false;

//         // Console.SetWindowSize(80,25);
//         // Console.SetBufferSize(80,25);

//         //플레이어 생성
//         Player player = new Player();
//         Enemy enemy = new Enemy();//적생성

//         //유니티처럼 속도 프레임 속도
//         int dwTime = Environment.TickCount; // 1/1000초가 흐른다.

//         while (true) //무한반복
//         {
//             //0.05초 지연
//             if (dwTime + 50 < Environment.TickCount)
//             {
//                 //현재시간 세팅
//                 dwTime = Environment.TickCount;
//                 Console.Clear();

//                 //플레이어
//                 player.GameMain();

//                 //총알
//                 if (player.iteCount == 0)
//                 {
//                     player.BulletDraw();
//                 }
//                 else if (player.iteCount == 1)
//                 {
//                     player.BulletDraw();
//                     player.BulletDraw2();
//                 }
//                 else
//                 {
//                     player.BulletDraw();
//                     player.BulletDraw2();
//                     player.BulletDraw3();
//                 }


//                 enemy.EnemyMove(); // 적이동
//                 enemy.EnemyDraw();  //적그리기

//                 //충돌처리
//                 player.ClashEnemyAndBullet(enemy);
//             }
//         }
//     }


// }