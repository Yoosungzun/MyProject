// using System;



// class Program
// {
//     //전역변수
//     static int num2 = 20;
//     //1.매개변수도 반환값도 없는 함수
//     static void PrinHello()
//     {
//         Console.WriteLine("안녕하세요.");
//     }

//     //2. 매개변수만 있는 함수
//     static void PrintMessage(string message)
//     {
//         {
//             Console.WriteLine(message);
//         }
//     }

//     //3. 반환값만 있는 함수
//     static int GetNumber()
//     {
//         return 42;
//     }

//     //4. 매개변수와 반환값이 있는 함수
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     //5. 기본값을 가진 매개변수 (디폴트 매개변수)
//     static void Greet(string name = "손님")
//     {
//         Console.WriteLine($"안녕하세요, {name}");
//     }

//     //. 함수 오버로딩(OverLoading)
//     static int Multiply(int a, int b)
//     {
//         return a * b;
//     }

//     static double Multiply(double a, double b)
//     {
//         return a * b;
//     }

//     //out 키워드 (여러값을 반환할때)
//     static void Divide(int a, int b, out int quotient, out int remainder)
//     {
//         quotient = a / b;
//         remainder = a % b;
//     }

//     //8.ref 키워드 (값을 참조하여 수정)
//     static void Increase(ref int num)
//     {
//         num += 10;
//     }

//     //params 키워드 (가변 매개변수)
//     static int Sum(params int[] numbers)
//     {
//         int total = 0;

//         foreach (int num in numbers)
//         {
//             total += num;
//         }
//         return total;
//     }

//     //재귀함수(자기 자신을 호출)
//     // static void Print()
//     // {
//     //     Console.WriteLine("나는 재귀함수다.");
//     //     Print();
//     // }
//     static int Factorial(int n)
//     {
//         if (n <= 1)
//         {
//             Console.WriteLine("*" + n);
//             return 1;
//         }
//         Console.WriteLine("*" + n);
//         return n * Factorial(n - 1);//5 * 4* *3 * 2* 1= 120
//     }


//     static void Main(string[] args)
//     {
//         // Greet();
//         // Greet("철수");

//         // PrinHello(); //출력
//         // PrintMessage("반갑습니다.");

//         // int num = GetNumber();
//         // Console.WriteLine(num);
//         // Console.WriteLine(num2);

//         // int result = Add(3, 5);
//         // Console.WriteLine(result);

//         // Console.WriteLine(Multiply(3, 4));
//         // Console.WriteLine(Multiply(3.5, 4.5));

//         // int q, r;
//         // Divide(10, 3, out q, out r);

//         // Console.WriteLine($"a몫: {q} ,나머지 : {r}");

//         // int value = 5;

//         // Increase(ref value);

//         // Console.WriteLine(value);

//         // Console.WriteLine(Sum(1, 2, 3));

//         // Console.WriteLine(Sum(1, 2, 3, 4, 4, 5, 6, 7, 8, 9));

//         Console.WriteLine(Factorial(5));






//     }
// }


