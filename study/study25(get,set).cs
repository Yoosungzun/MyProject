// using System;
// using System.Globalization;

// class Person
// {
//     // private string name; //내부 변수
//     // //값 설정하기 (Setter)
//     // public void SetName(string newName)
//     // {
//     //     name = newName;
//     // }

//     // //값 가져오기 (Getter)
//     // public string GetName()
//     // {
//     //     return name;
//     // }

//     //c# 프로퍼티 property

//     // private string name;
//     // public string Name
//     // {
//     //     get { return name; } //get
//     //     set { name = value; } //set
//     // }

//     //프로퍼티 자동 구현
//     // public string Name { get; set; } //자동 구현 프로퍼티

//     // private int count = 100;
//     // public string Name { get; set; }
//     // public int Count
//     // {
//     //     get { return count; }
//     // }

//     // public float Balance { get; private set; }
//     // public void AddBal()
//     // {
//     //     Balance += 100;
//     // }


// }

// class Marin
// {
//     public string Name { get; private set; } = "마린";
//     public int Mineral { get; set; } = 100;

// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         //c#에서 get/set 방식의 함수와 프로퍼티 비교
//         //c#에서는 객체의 값을 읽고(get),설정(set)하는
//         //방식으로 함수(get/set 메서드)또는
//         //**프로퍼티** 사용 할수 있습니다.

//         // Person p = new Person();

//         // // p.SetName("홍길동");
//         // p.Name = "홍길동";
//         // p.AddBal();

//         // // Console.WriteLine("이름 : " + p.GetName());
//         // Console.WriteLine("이름 : " + p.Name + " Count :" + p.Count + " Balance : " + p.Balance);

//         Marin m = new Marin();

//         Console.WriteLine($"이름 : {m.Name} 미네랄 : {m.Mineral}");

//     }
// }