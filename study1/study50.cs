// using System;

// class Person
// {
//     public string Name;
//     public int Age;
//     public Person() //생성자
//     {
//         Name = "Unknown";
//         Age = 0;
//     }
//     public Person(string name)
//     {
//         Name = name;
//         Age = 0;
//     }
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Person p = new Person(); //생성자 호출
//         Person p1 = new Person("Bob"); //1개짜리 매개변수 있는 생성자
//         Person p2 = new Person("엘리스", 16);    //2개짜리 매개변수 있는 생성자자

//         Console.WriteLine(p.Name + "," + p.Age);
//         Console.WriteLine(p1.Name + "," + p1.Age);
//         Console.WriteLine(p2.Name + "," + p2.Age);
//     }
// }