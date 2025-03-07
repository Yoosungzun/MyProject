// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("플레이어의 소지금을 입력하세요 :");
//         int playerGold = int.Parse(Console.ReadLine());

//         Shop shop = new Shop();
//         Player player = new Player(playerGold);

//         while (true)
//         {
//             shop.DisplayItems();
//             Console.WriteLine("구매할 아이템 번호 입력 (4: 종료):");
//             int choice = int.Parse(Console.ReadLine());

//             if (choice == 4)
//             {
//                 Console.WriteLine("상점 종료!");
//                 break;
//             }

//             shop.BuyItem(choice, ref player);
//         }


//     }

//     struct Item
//     {
//         public string Name;
//         public int Price;

//         public Item(string name, int price)
//         {
//             Name = name;
//             Price = price;
//         }
//     }

//     struct Player
//     {
//         public int Gold;
//         public string[] Inventory;
//         private int itemCount;

//         public Player(int gold)
//         {
//             Gold = gold;
//             Inventory = new string[10];
//             itemCount = 0;
//         }

//         public bool BuyItem(Item item)
//         {
//             if (Gold >= item.Price)
//             {
//                 Gold -= item.Price;
//                 Inventory[itemCount] = item.Name;
//                 itemCount++;
//                 Console.WriteLine($"{item.Name}을 구매했습니다! 남은 골드 : {Gold}");
//                 return true;
//             }
//             else
//             {
//                 Console.WriteLine("골드가 부족합니다!");
//                 return false;
//             }
//         }
//     }

//     struct Shop
//     {
//         private Item[] items;

//         public Shop()
//         {
//             items = new Item[]
//             {
//                 new Item("포션", 100),
//                 new Item("검", 300),
//                 new Item("방패", 200)
//             };
//         }

//         public void DisplayItems()
//         {
//             Console.WriteLine("\n 상점에서 구매할 아이템을 선택하세요:");
//             for (int i = 0; i < items.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}.{items[i].Name}({items[i].Price})");
//             }
//             Console.WriteLine("4.종료");
//         }

//         public void BuyItem(int choice, ref Player player)
//         {
//             if (choice < 1 || choice > items.Length)
//             {
//                 Console.WriteLine("잘못된 선택입니다!");
//                 return;
//             }

//             player.BuyItem(items[choice - 1]);
//         }
//     }




// }