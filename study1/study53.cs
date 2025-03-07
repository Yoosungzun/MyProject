// using System;

// class Parent
// {
//     // public Parent(string message)
//     // {
//     //     Console.WriteLine("부모생성자 " + message); // 2실행
//     // }

//     protected string name;
//     //부모 생성자에서 name 초기화
//     public Parent(string name) //2
//     {
//         this.name = name;
//         Console.WriteLine($"부모 생성자 : {name}");
//     }
// }
// class Child : Parent
// {
//     // public Child() : base("하하하하하성공") //부모생성자 호출 1
//     // {
//     //     Console.WriteLine("자식 생성자 호출"); //3
//     // }

//     private int age;
//     //부모 생성자를 호출하면서 name 전달 + 추가로 age 초기화
//     public Child(string name, int age) : base(name) //1
//     {
//         this.age = age;
//         Console.WriteLine($"자식 생성자: 나이 = {age}");
//         // this.name = base.name;
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {name}, 나이 : {age}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Child child = new Child(); //0객체 생성 시작작
//         Child child = new Child("홍길동", 25); //0
//         child.ShowInfo();
//     }
// }