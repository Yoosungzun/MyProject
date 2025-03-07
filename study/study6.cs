// using System;
// using System.Collections.Generic;
// using System.Data.SqlTypes;
// using System.Linq;
// using System.Reflection.Metadata.Ecma335;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.VisualBasic;

// namespace study6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // //이진수를 정수로 변환
//             // Console.Write("2진수를 입력하세요:");
//             // string binaryInput = Console.ReadLine(); //입력 받는다 문자열
//             // int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 - > 10진수 변환

//             // //정수를 이진수로 변환
//             // string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 > 2진수

//             // Console.WriteLine($"입력한 이진수: {binaryInput}");
//             // Console.WriteLine($"10진수로 변환 : {decimalValue}");
//             // Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");
//               //var 를 사용하여 변수 선언
//             // var name = "Alice"; 
//             // var age = 25;
//             // var isStudent = true;

//             // Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

//             // //deafault 키워드 사용한 기본값
//             // int defaultInt = default; //기본값 : 0;
//             // string defaultString = default; //기본값 : null;
//             // bool defaultBool = default; //기본값 : false

//             // Console.WriteLine($"정수 기본값 : {defaultInt}");
//             // Console.WriteLine($"문자열 기본값 : {defaultString}");
//             // Console.WriteLine($"논리값값 기본값 : {defaultBool}");

//             // int a = 5, b =3;

//             // int sum = 0;

//             // sum = a + b; //산술 연산자 사용

//             // Console.WriteLine($"합 : {sum}");

//             // sum = a - b; //산술 연산자 사용

//             // Console.WriteLine($"합 : {sum}");

//             // sum = a * b; //산술 연산자 사용

//             // Console.WriteLine($"합 : {sum}");

//             // sum = a / b; //산술 연산자 사용

//             // Console.WriteLine($"합 : {sum}");

//             // sum = a % b; //산술 연산자 사용

//             // Console.WriteLine($"합 : {sum}");

//             // bool isEqual = false; //거짓 0

//             // int a = 5;
//             // int b = 5;

//             // //관계형 연산자
//             // isEqual = (a == b);

//             // Console.WriteLine("같은가?" +isEqual);

//             //단항 연산자
//             // int number = 5;
//             // bool flag = true;

//             // Console.WriteLine(+ number); //양수 출력 : 5
//             // Console.WriteLine(-number); //음수 출력 : -5

//             // Console.WriteLine(!flag); //논리 부정: false

//             // int iKor = 90;
//             // int iEng = 75;
//             // int iMath = 58;

//             // int sum = 0;
//             // float average = 0.0f;

//             // sum = iKor + iEng + iMath;

//             // average = (float)sum /3; //평균

//             // Console.WriteLine("총점 : " + sum);
//             // Console.WriteLine("평균 : " + average);

//             // int a = 10, b =3;

//             // Console.Write(a +b);
//             // Console.WriteLine(a -b);
//             // Console.WriteLine(a * b);
//             // Console.WriteLine(a / b);
//             // Console.WriteLine(a % b);

//             //문자열 연결 연산자

//             // string firstName = "Alice";
//             // string lastName = "Smith";

//             // Console.WriteLine(firstName + " " + lastName); //출력
//             // int a = 10;
//             // a += 5; // a = a+5;
//             // Console.WriteLine(a);
//             // a -= 5; // a = a-5;
//             // Console.WriteLine(a);
//             // a *= 5; //a = a*5;
//             // Console.WriteLine(a);
//             // a /= 5; //a = a/5;
//             // Console.WriteLine(a);
//             // a %=5; //a = a%5;
//             // Console.WriteLine(a);

//             //int) 국어 , 영어 , 수학 점수
//             //총점 구하기.
//             //평균 계산시 실수로
            

//             // Console.WriteLine("국어 점수를 작성하시오 :");
//             // int kor = int.Parse(Console.ReadLine()??"0");
//             // Console.WriteLine("영어 점수를 작성하시오 :");
//             // int eng = int.Parse(Console.ReadLine()??"0");
//             // Console.WriteLine("수학 점수를 작성하시오 :");
//             // int math = int.Parse(Console.ReadLine()??"0");

//             // int sum = kor + eng + math;

//             // float average = (float)sum /3;

//             // Console.WriteLine("당신의 평균 점수는?  " +average.ToString("F2"));

//             // Console.WriteLine("정수를 입력하시오 :");
//             // int num = int.Parse(Console.ReadLine()??"0");
//             // Console.WriteLine("작성한 정수는  " + num);
//             // Console.WriteLine("비트반전 연산자는  " + ~num);
//             //해당 정수의 비트를 반전을 출력하는 프로그램
//             //원래의 값과 비트 반전의 값을 출력

//             //증감 연산자

//             // int b = 3;

//             // //전위 ++b , 후위 b++
//             // Console.WriteLine("b의 값은: " + (b++));
//             // Console.WriteLine("b의 값은: " + (b));

//             // int money = 0 ;
//             // int atk = 0;
//             // string name = "";

//             // Console.WriteLine("가지고 있는 소지금을 입력하세요. : ");
//             // money = int.Parse(Console.ReadLine()??"0");

//             // if( money > 0 && money <=100)
//             // {
//             //      atk = 1;
//             //      name = "무한의 대검";
//             //     Console.WriteLine(name + atk);
//             // }
//             // else if( money > 100 && money <=200)
//             // {
//             //      atk = 2;
//             //      name = "카타나";
//             //     Console.WriteLine(name + atk);
//             // }
//             // else if( money > 200 && money <=300)
//             // {
//             //      atk = 3;
//             //      name = "진은검";
//             //     Console.WriteLine(name + atk);
//             // }

//             // else if( money > 300 && money <=400)
//             // {
//             //      atk = 4;
//             //      name = "집판검";
//             //     Console.WriteLine(name + atk);
//             // }
//             // else if( money > 400 && money <=500)
//             // {
//             //      atk = 5;
//             //      name = "엑스칼리버";
//             //     Console.WriteLine(name + atk);
//             // }
//             // else if( money > 500 && money <=600)
//             // {
//             //      atk = 6;
//             //      name = "유령검";
//             //     Console.WriteLine(name + atk);
//             // }
//             // else if( money > 600)
//             // {
//             //      atk = 7;
//             //      name = "전설의검";
//             //     Console.WriteLine(name + atk);               
//             // }
//             // else
//             // {
//             //     Console.WriteLine("정확한 수치를 입력하세요.");
//             // }

//             // Console.WriteLine("캐릭터 : 멋사검존");
//             // Console.WriteLine("무기 : " + name);
//             // Console.WriteLine("공격력 : 100" + atk);

//             //세 정수의 최대값 구하기
//             int num1 = 0, num2 = 0, num3 = 0;
//             int max = 0;

//             Console.WriteLine("3개의 정수를 입력하세요.");
//             num1 = int.Parse(Console.ReadLine()?? "0");
//             num2 = int.Parse(Console.ReadLine()?? "0");
//             num3 = int.Parse(Console.ReadLine()?? "0");

//             if (num1 >= num2 && num1 >= num3)
//             {
//                 max = num1;
                
//             } 
//             else if (num2 >= num1 && num2 >= num3)
//             {
//                 max = num2;
//             }
//             else
//             {
//                 max = num3;
//             }

//             Console.WriteLine("가장 큰 최대값 : " + max);
//             Console.WriteLine("");
//             Console.WriteLine("");

        
//             int score = 0 ;
//             string grade = "";
//             Console.WriteLine("점수를 입력하세요. : ");
//             score = int.Parse(Console.ReadLine()??"");
//             if (score >= 90)
//             {
//                 grade = "A";
//             }
//             else if (score >= 80 && score <90)
//             {
//                 grade = "B";
//             }
//             else if (score >= 70 && score <80)
//             {
//                 grade = "C";
//             }
//             else if (score >= 60 && score <70)
//             {
//                 grade = "D";
//             }
//             else 
//             {
//                 grade = "F";
//             }

//             Console.WriteLine($"당신의 학점은 {grade} 입니다.");
//             Console.WriteLine("");
//             Console.WriteLine("");


//             int a =0,b=0,c=0;
//             string ope;
//             Console.WriteLine("두개의 숫자와 연산자를 입력하세요.");
//             a = int.Parse(Console.ReadLine()??"0");
//             ope = Console.ReadLine()??"";
//             b = int.Parse(Console.ReadLine()??"0");
//             if(ope == "+")
//             {
//                 c = a+b;
//             }
//             else if(ope == "-")
//             {
//                 c = a-b;
//             }
//             else if(ope == "*")
//             {
//                 c = a*b;
//             }
//             else if(ope == "/")
//             {
//                 if(b>0)
//                 {
//                    c = a/b;     
//                 }
//                 else
//                 {
//                     Console.WriteLine("0이상의 값으로 나눠주세요.");
//                 }
                
//             }
//             else if(ope == "%")
//             {
//                 if(b>0)
//                 {
//                    c = a%b;     
//                 }
//                 else
//                 {
//                     Console.WriteLine("0이상의 값으로 나눠주세요.");
//                 }
//             }

//             Console.WriteLine("결과 : " + c);


//         }
        
        
      
//     }
// }