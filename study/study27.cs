// using System;
// using System.Collections.Generic;


// public class Player
// {
//     public List<Bullet> bullets = new List<Bullet>();
//     public int playerX;
//     public int playerY;
//     public string[] playerSprit;
//     public int bulletUpgradeLevel = 0;

//     public void PlayerDraw()
//     {
//         string[] playerSprit = new string[]
//         {
//             "->",
//             ">>>",
//             "->"
//         };
//         for (int i = 0; i < playerSprit.Length; i++)
//         {
//             int newY = playerY + i;
//             if (newY >= Console.BufferHeight)
//                 newY = Console.BufferHeight - 1;
//             Console.SetCursorPosition(playerX, newY);
//             Console.Write(playerSprit[i]);
//         }

//     }

//     public void PlayerMove()
//     {
//         if (Console.KeyAvailable)
//         {
//             ConsoleKeyInfo keyInfo = Console.ReadKey(true);
//             switch (keyInfo.Key)
//             {
//                 case ConsoleKey.UpArrow:
//                     playerY = Math.Max(1, playerY - 1);
//                     break;
//                 case ConsoleKey.DownArrow:
//                     playerY = Math.Min(Console.BufferHeight - 4, playerY + 1);
//                     break;
//                 case ConsoleKey.LeftArrow:
//                     playerX = Math.Max(1, playerX - 1);
//                     break;
//                 case ConsoleKey.RightArrow:
//                     playerX = Math.Min(Console.BufferWidth - 4, playerX + 1);
//                     break;
//                 case ConsoleKey.Spacebar:
//                     BulletFire(); // 스페이스바를 누르면 총알 발사
//                     break;
//             }
//         }
//     }

//     public void BulletFire()
//     {

//         bullets.Add(new Bullet(playerX + 3, playerY + 1));

//         if (bulletUpgradeLevel >= 1)
//         {
//             bullets.Add(new Bullet(playerX + 3, playerY));
//         }
//         if (bulletUpgradeLevel >= 2)
//         {
//             bullets.Add(new Bullet(playerX + 3, playerY + 2));
//         }
//         if (bulletUpgradeLevel >= 3)
//         {
//             bullets.Add(new Bullet(playerX + 3, playerY - 1));
//             bullets.Add(new Bullet(playerX + 3, playerY + 3));
//         }

//     }

//     public void UpgradeBullet()
//     {
//         if (bulletUpgradeLevel < 3)
//         {
//             bulletUpgradeLevel++;
//         }
//     }

//     public void UpdateBullets()
//     {
//         foreach (Bullet bullet in bullets)
//         {
//             bullet.BulletMove();
//             bullet.BulletDraw();
//         }
//         bullets.RemoveAll(b => !b.fire);


//     }
// }



// public class Enemy
// {
//     public UI ui = new UI();
//     public static List<Item> itemList = new List<Item>();
//     public int enemyX;
//     public int enemyY;
//     public string enemySprite = "<-0->";
//     public bool isAlive = true;


//     public void EnemyDraw()
//     {
//         Console.SetCursorPosition(enemyX, enemyY);
//         Console.Write(enemySprite);
//     }

//     public void EnemyMove()
//     {

//         Random random = new Random();
//         enemyX--;

//         if (!isAlive) // 적이 죽으면 초기 위치로 재생성
//         {
//             itemList.Add(new Item(enemyX, enemyY));
//             UI.ScoreUpdate();

//             enemyX = Console.BufferWidth - 1;
//             enemyY = random.Next(2, Console.BufferHeight - 2);
//             isAlive = true;

//             return;
//         }

//         enemyX--; // 적 이동

//         if (enemyX < 2) // 화면 밖으로 나가면 초기 위치로 재생성
//         {
//             enemyX = Console.BufferWidth - 1;
//             enemyY = random.Next(2, Console.BufferHeight - 2);
//         }
//     }
// }

// public class Bullet
// {
//     public int bulletX;
//     public int bulletY;
//     public bool fire = true;
//     public string bulletSprit = "->";
//     public Bullet(int x, int y)
//     {
//         bulletX = x;
//         bulletY = y;
//     }

//     public void BulletDraw()
//     {
//         if (fire)
//         {
//             Console.SetCursorPosition(bulletX + 1, bulletY);
//             Console.Write(bulletSprit);
//         }

//     }

//     public void BulletMove()
//     {
//         if (fire)
//         {
//             if (bulletX < Console.BufferWidth - 2)
//             {
//                 bulletX++;
//             }
//             else
//             {
//                 fire = false;
//             }
//         }
//     }
// }

// public class Clash
// {
//     public bool CheckCollision(Bullet bullet, Enemy enemy)
//     {
//         if (bullet.fire && bullet.bulletX == enemy.enemyX && bullet.bulletY == enemy.enemyY)
//         {
//             bullet.fire = false;
//             enemy.isAlive = false;

//             return true;
//         }
//         return false;
//     }

//     public bool CheckItemCollision(Player player, Item item)
//     {
//         if (player.playerX + 1 == item.ItemX + 1 && player.playerY + 1 == item.ItmeY)
//         {
//             player.UpgradeBullet();
//             Enemy.itemList.Remove(item);

//         }
//         return false;
//     }

// }

// public class Item
// {
//     public int ItemX;
//     public int ItmeY;
//     public string ItmeSprit = "★★★";
//     public bool ItemLife = false;

//     public Item(int x, int y)
//     {
//         ItemX = x;
//         ItmeY = y;
//     }
//     public void ItemDraw()
//     {
//         Console.SetCursorPosition(ItemX, ItmeY);
//         Console.Write(ItmeSprit);
//     }



// }

// public class UI
// {
//     public static int Score = 0;
//     public static void UIScore()
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

//     public static void ScoreUpdate()
//     {
//         Score += 100;
//         UIScore();
//     }

// }

// public class GameMager
// {
//     Player Player = new Player();
//     Enemy enemy = new Enemy();
//     Clash clash = new Clash();


//     public void GameUpdate()
//     {
//         Console.Clear();
//         Player.PlayerMove();
//         Player.PlayerDraw();
//         Player.UpdateBullets();

//         enemy.EnemyDraw();
//         enemy.EnemyMove();

//         UI.UIScore();




//         // 충돌 검사 및 적 리스폰 처리
//         foreach (Bullet bullet in Player.bullets)
//         {
//             if (clash.CheckCollision(bullet, enemy))
//             {
//                 enemy.isAlive = false;
//             }
//         }
//         for (int i = Enemy.itemList.Count - 1; i >= 0; i--)
//         {
//             if (clash.CheckItemCollision(Player, Enemy.itemList[i]))
//             {
//                 Enemy.itemList.RemoveAt(i);
//             }
//         }

//         foreach (Item item in Enemy.itemList)
//         {
//             item.ItemDraw();
//         }
//     }
// }
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.CursorVisible = false;
//         GameMager gameMager = new GameMager();

//         int dwTime = Environment.TickCount;

//         while (true)
//         {
//             if (dwTime + 50 < Environment.TickCount)
//             {
//                 dwTime = Environment.TickCount;
//                 gameMager.GameUpdate();


//             }
//         }

//     }
// }