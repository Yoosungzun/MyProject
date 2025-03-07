// using System;
// using System.Globalization;


// class Person

// {
//     public string Name;
//     public int Age;

//     //기본생성자
//     //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드(함수)
//     //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지 않음)
//     //객체를 만들때 필요한 초기값을 설정할 때 사용 많이 한다.

//     public Person()
//     {

//     }
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//         Console.WriteLine("기본 생성자가 실행됨");
//     }
//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
//     }
// }

// class Marin
// {
//     public string Name;
//     public int Mineral;
//     public Marin()
//     {
//         Name = "마린";
//         Mineral = 50;
//     }

//     public Marin(string _name, int _mineral)
//     {
//         Name = _name;
//         Mineral = _mineral;

//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name} , 미네랄 : {Mineral}");
//     }
// }
// class SCV
// {
//     public string Name;
//     public int Mineral;
//     public SCV()
//     {
//         Name = "SCV";
//         Mineral = 50;
//     }
//     public SCV(string _name, int _mineral)
//     {
//         Name = _name;
//         Mineral = _mineral;

//     }
//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name} , 미네랄 : {Mineral}");
//     }
// }


// //배럭클래스
// //this 키워드를 이용해 보자
// //this 자기를 가르킨다.
// class Barracks
// {
//     public string Name;
//     public int Mineral;
//     public Barracks()
//     {
//         Name = "배럭";
//         Mineral = 150;
//     }
//     public Barracks(string Name, int Mineral)
//     {
//         this.Name = Name;
//         this.Mineral = Mineral;
//     }
//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 미네랄: {Mineral}");
//     }
// }

// //미네날 클래스 1500 * 7
// class Mineral
// {

//     public int MinerlaCount;
//     public Mineral()
//     {
//         MinerlaCount = 1500;
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"미네랄 수량 : {MinerlaCount}");
//     }
// }

// //Game클래스를 만들어보자
// class Game
// {
//     public static int mineral;
//     public static int gas;
//     public static int charCount;

//     public static void ShowInfo()
//     {
//         Console.WriteLine($"미네랄: {mineral}, 가스 :{gas}, 인구수 : {charCount}");
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         Game.mineral = 50;
//         Game.gas = 0;
//         Game.charCount = 4;
//         Game.ShowInfo();

//         // Person p1 = new Person("철수", 25); //객체 생성 instance
//         // p1.ShowInfo();
//         // Person p2 = new Person("영희", 30);
//         // p2.ShowInfo();


//         Marin marin = new Marin("불꽃테란", 100);
//         SCV scv = new SCV("열받은 SCV", 70);
//         Barracks barracks = new Barracks();
//         //클래스의 배열
//         Mineral[] minerals = new Mineral[7];
//         //각 배열에 new 객체화
//         for (int i = 0; i < minerals.Length; i++)
//         {
//             minerals[i] = new Mineral();
//             minerals[i].ShowInfo();
//         }




//         marin.ShowInfo();
//         scv.ShowInfo();
//         barracks.ShowInfo();

//     }
// }