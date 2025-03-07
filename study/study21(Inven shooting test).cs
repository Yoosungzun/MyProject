// using System;

// class Program
// {
//     //최대 아이템 개수 (배열 크기)
//     const int MAX_ITEMS = 10;

//     struct Item
//     {
//         public string Name;
//         public int Count;

//         public Item(string name, int count)
//         {
//             Name = name;
//             Count = count;
//         }
//     }
//     struct Inventory
//     {
//         //아이템 배열 (이름 저장)
//         private Item[] items;
//         private int itemCounts;

//         public Inventory(bool initialize)
//         {
//             items = new Item[MAX_ITEMS];
//             itemCounts = 0;
//         }
//         //아이템 추가 함수
//         public void AddItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (items[i].Name == name) //이미 있는 아이템이면 개수 증가
//                 {
//                     items[i].Count += count;
//                     return;
//                 }
//             }
//             //빈 슬롯에 새로운 아이템 추가
//             if (itemCounts < MAX_ITEMS)
//             {
//                 items[itemCounts] = new Item(name, count);
//                 itemCounts++;
//             }
//             else
//             {
//                 Console.WriteLine("인벤토리가 가득 찾습니다.");
//             }


//         }
//         //아이템 제거 함수
//         public void RemoveItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (items[i].Name == name) //이름 하고 같은지
//                 {
//                     if (items[i].Count >= count) //갯수가 충분하면 차감
//                     {
//                         items[i].Count -= count;
//                         if (items[i].Count == 0) //개수가 0이면 삭제제
//                         {
//                             items[i].Name = null;
//                         }
//                         return;
//                     }
//                     else
//                     {
//                         Console.WriteLine("아이템 개수가 부족합니다!");
//                         return;
//                     }

//                 }


//             }
//             Console.WriteLine("아이템을 찾을수 없습니다.");
//         }
//         //인벤토리 출력함수
//         public void ShowInventory()
//         {
//             Console.WriteLine("현재 인벤토리 :");


//             if (itemCounts == 0)
//             {
//                 Console.WriteLine("인벤토리가 비어 있습니다.");
//             }
//             else
//             {
//                 for (int i = 0; i < itemCounts; i++)
//                 {
//                     Console.WriteLine($"{items[i].Name} (x{items[i].Count})");
//                 }
//             }


//         }

//     }



//     static void Main(string[] args)
//     {
//         Inventory inventory = new Inventory(true);
//         //테스트 : 아이템 추가
//         inventory.AddItem("포션", 5);
//         inventory.AddItem("칼", 1);
//         inventory.AddItem("포션", 3); //포션 개수 추가

//         inventory.ShowInventory();
//         //아이템 사용
//         Console.WriteLine("포션 2개 사용");
//         inventory.RemoveItem("포션", 2);
//         inventory.ShowInventory();

//         //테스트 : 없는 아이템 제거
//         Console.WriteLine("방패 1개 제거 시도");
//         inventory.RemoveItem("방패", 1);

//         inventory.ShowInventory();

//         //테스트: 모든 포션 제거
//         Console.WriteLine("포션 6개 사용 (초과 사용 테스트)");
//         inventory.RemoveItem("포션", 7);
//         inventory.ShowInventory();
//     }

// }