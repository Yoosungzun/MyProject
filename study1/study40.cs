// using System;


// //업캐스팅(Upcasting)
// //자식 클래스 -> 부모클래스로 변환하는것
// //암시적 변환이 가능(컴파일러가 자동변환)
// //안전: 데이터 손실 없이 변환가능
// //다운캐스팅
// //명시적 변환이 필요 (타입)
// //불완전함 ㅋ-> 실행중 InvalidCastException발생 가능
// //as is 키워드로 안전하게 변환가능
// class Animal //부모 객체
// {
//     public void Speak()
//     {
//         Console.WriteLine(("동물이 소리를 냅니다."));
//         {

//         }
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("멍멍!");
//     }
// }
// class Program
// {
//     static void Mian(string[] args)
//     {
//         // Dog myDog = new Dog(); //자식클래스 객체 생성
//         // Animal myAnimal = myDog; //업케스팅(Dog ->animal)

//         // myAnimal.Speak(); //사용 가능

//         // myDog.Bark();

//         //myAnimal.Bark() 오류 업캐스팅후 자식 클래스의매서드는 접근 불가.

//         Animal myAnimal = new Dog(); //업케스팅
//                                      // Dog myDog = (Dog)myAnimal; //다운캐스팅 (aud시적 변환)

//         Dog myDog = myAnimal as Dog;
//         if (myDog != null)
//         {
//             myDog.Bark();// 실행
//         }
//         else
//         {
//             Console.WriteLine("변환할 수 없습니다.");
//         }


//         if (myAnimal is Dog mydog1)
//         {
//             mydog1.Bark();
//         }
//         else
//         {
//             Console.WriteLine("변환할 수 없습니다.");
//         }


//     }
// }