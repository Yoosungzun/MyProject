// using System;


// class Program
// {
//     static void Main(string[] args)
//     {
//         // int[] num = new int[3]; //3개 메모리 만들겠다.

//         // num[0] = 10;
//         // num[1] = 20;
//         // num[2] = 30;

//         // Console.WriteLine(num[0]);
//         // Console.WriteLine(num[1]);
//         // Console.WriteLine(num[2]);

//         // for (int i = 0; i < 3; i++)
//         // {
//         //     Console.WriteLine(num[i]);
//         // }

//         // int[] numbers = { 1, 2, 3 }; //간단한 선언과 초기화
//         // int[] numbers2 = new int[3]; //크기만 지정
//         // int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

//         // for (int i = 0; i < 3; i++)
//         // {
//         //     Console.WriteLine(numbers3[i]);
//         // }

//         // string[] fruits = { "사과", "바나나", "오렌지" };

//         // for (int i = 0; i < 3; i++)
//         // {
//         //     Console.WriteLine(fruits[i]);
//         // }


//         // int[] iKor = new int[3];
//         // int[] iEng = new int[3];
//         // int[] iMath = new int[3];

//         // int[] sum = new int[3];
//         // float[] aver = new float[3];

//         // for (int i = 0; i < 3; i++)
//         // {
//         //     Console.WriteLine("학생 성적입력하세요 :");
//         //     Console.Write("국어 :");
//         //     iKor[i] = int.Parse(Console.ReadLine());
//         //     Console.Write("영어 :");
//         //     iEng[i] = int.Parse(Console.ReadLine());
//         //     Console.Write("수학 :");
//         //     iMath[i] = int.Parse(Console.ReadLine());

//         //     sum[i] = iKor[i] + iEng[i] + iMath[i];
//         //     aver[i] = (float)sum[i] / 3;
//         // }
//         // //출력
//         // for (int i = 0; i < 3; i++)
//         // {
//         //     Console.WriteLine((i + 1) + "번학생");
//         //     Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]} ");
//         //     Console.WriteLine("총점 : " + sum[i]);
//         //     Console.WriteLine("평균 : " + aver[i].ToString("F2"));
//         // }

//         //1차원 배열
//         // int[] scores = new int[3];

//         // scores[0] = 90;
//         // scores[1] = 85;
//         // scores[2] = 88;

//         // for (int i = 0; i < scores.Length; i++)
//         // {
//         //     Console.WriteLine($"점수 {i + 1}: {scores[i]}");
//         // }

//         // double value = 123.456789;
//         // //소수점 자릿수 설정하는 포맷
//         // Console.WriteLine(value.ToString("F2"));
//         // Console.WriteLine($"소수점 둘째짜리 : {value:F2}");
//         // Console.WriteLine(string.Format("소수점 둘째 자리 : {0:F2}",value));
//         // //소수점 없이 정수 출력
//         // Console.WriteLine(value.ToString("F0"));

//         // double value = 1231424125125.1234124;

//         // Console.WriteLine(value.ToString("N2"));

//         //2차원 배열 선언
//         // int[,] matrix = new int[2, 3]
//         // {
//         //     {1,2,3},
//         //     {4,5,6}
//         // };

//         // for (int i = 0; i < 2; i++)
//         // {

//         //     for (int j = 0; j < 3; j++)
//         //     {
//         //         Console.Write($"{matrix[i, j]}");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // int[][] matrix = new int[2][];

//         // matrix[0] = new int[3];
//         // matrix[1] = new int[3];

//         // //값 입력
//         // matrix[0][0] = 1;
//         // matrix[0][1] = 2;
//         // matrix[0][2] = 3;

//         // matrix[1][0] = 4;
//         // matrix[1][1] = 5;
//         // matrix[1][2] = 6;

//         // for (int i = 0; i < matrix.Length; i++)
//         // {
//         //     for (int j = 0; j < matrix[i].Length; j++)
//         //     {
//         //         Console.WriteLine(matrix[i][j] + " ");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // Console.WriteLine("가변배열");
//         // int[][] jaggedArray = new int[3][];

//         // jaggedArray[0] = new int[] { 1, 2 };
//         // jaggedArray[1] = new int[] { 3, 4, 5 };
//         // jaggedArray[2] = new int[] { 6 };

//         // for (int i = 0; i < jaggedArray.Length; i++)
//         // {
//         //     for (int j = 0; j < jaggedArray[i].Length; j++)
//         //     {
//         //         Console.Write($"{jaggedArray[i][j]}");
//         //     }
//         //     Console.WriteLine();
//         // }

//         // Console.WriteLine("var 키워드 사용");
//         // var numbers = new[] { 1, 2, 3, 4, 5 };
//         // Console.WriteLine($"배열 타입 : {numbers.GetType()}");

//         // int[] iArray = new int[] { 0 };

//         // //셔플
//         // //스왑
//         // int a = 10;
//         // int b = 20;
//         // int t = 0;

//         // t = a;
//         // a = b;
//         // b = t;

//         // Console.Write("a : " + a + "  b: " + b);
//         // int[] iArray = new int[25];

//         // for (int i = 0; i < 25; i++)
//         // {
//         //     iArray[i] = i + 1;
//         // }



//         // Random rand = new Random();
//         // //셔플
//         // for (int i = 0; i < 100; i++)
//         // {
//         //     int iA = rand.Next(0, 25);
//         //     int iB = rand.Next(0, 25);
//         //     int iT = 0;

//         //     iT = iArray[iA];
//         //     iArray[iA] = iArray[iB];
//         //     iArray[iB] = iT;
//         // }

//         // int input = 0;
//         // int iCount = 0;
//         // int iBingo = 0;


//         // while (true)
//         // {
//         //     Console.Clear();

//         //     //빙고판
//         //     for (int i = 0; i < 5; i++)
//         //     {
//         //         for (int j = 0; j < 5; j++)
//         //         {
//         //             if (iArray[i * 5 + j] == 0)
//         //             {
//         //                 Console.Write(" * "); //0일경우 체크크
//         //             }
//         //             else
//         //             {
//         //                 Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
//         //             }

//         //         }
//         //         Console.WriteLine();
//         //     }
//         //     Console.WriteLine("빙고 숫자 : " + iBingo);
//         //     Console.WriteLine("숫자를 입력하세요: ");
//         //     input = int.Parse(Console.ReadLine());
//         //     iBingo = 0;

//         //     for (int i = 0; i < 25; i++)
//         //     {
//         //         if (iArray[i] == input)
//         //         {
//         //             iArray[i] = 0;
//         //             break;
//         //         }
//         //     }

//         //     //빙고 체크 로직
//         //     //가로 체크
//         //     for (int i = 0; i < 5; i++)
//         //     {
//         //         for (int j = 0; j < 5; j++)
//         //         {
//         //             if (iArray[i * 5 + j] == 0)
//         //             {
//         //                 ++iCount;
//         //             }

//         //             if (iCount == 5)
//         //             {
//         //                 ++iBingo;
//         //             }
//         //         }
//         //         iCount = 0;
//         //     }
//         //     //세로 체크
//         //     for (int i = 0; i < 5; i++)
//         //     {
//         //         for (int j = 0; j < 5; j++)
//         //         {
//         //             if (iArray[i + j * 5] == 0)
//         //             {
//         //                 ++iCount;
//         //             }

//         //             if (iCount == 5)
//         //             {
//         //                 iBingo++;
//         //             }
//         //         }
//         //         iCount = 0;
//         //     }

//         //     //대각선 오른쪽체크
//         //     for (int i = 0; i < 5; i++)
//         //     {
//         //         if (iArray[i * 4 + 4] == 0)
//         //         {
//         //             ++iCount;
//         //         }

//         //         if (iCount == 5)
//         //         {
//         //             iBingo++;
//         //         }
//         //     }
//         //     iCount = 0;
//         //     //대각선 왼쪽 체크
//         //     for (int i = 0; i < 5; i++)
//         //     {
//         //         if (iArray[i * 6] == 0)
//         //         {
//         //             ++iCount;
//         //         }

//         //         if (iCount == 5)
//         //         {
//         //             iBingo++;
//         //         }
//         //     }
//         //     iCount = 0;

//         //     if (iBingo >= 5)
//         //     {
//         //         Console.WriteLine("빙고 성공");
//         //         break;
//         //     }
//         // }

//         int[,] boad = new int[5, 5]; //5x5빙고판
//         bool[,] marked = new bool[5, 5]; //선택된 숫자 체크
//         int bingoCount = 0;

//         Random random = new Random();

//         //빙고판 초기화
//         int[] numbers = new int[25];

//         for (int i = 0; i < 25; i++)
//             numbers[i] = i + 1;

//         //랜덤 섞기
//         for (int i = 0; i < 100; i++)
//         {
//             int a = random.Next(25);
//             int b = random.Next(25);
//             (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
//         }
//         //2차원 배열로 변화
//         int index = 0;
//         for (int i = 0; i < 5; i++)
//         {
//             for (int j = 0; j < 5; j++)
//             {
//                 boad[i, j] = numbers[index++];
//             }
//         }

//         //게임 시작
//         while (bingoCount < 5)
//         {
//             Console.Clear();
//             //빙고판 출력
//             Console.WriteLine("현재 빙고판");

//             for (int i = 0; i < 5; i++)
//             {
//                 for (int j = 0; j < 5; j++)
//                 {
//                     if (marked[i, j])
//                         Console.Write(" x ");
//                     else
//                         Console.Write($"{boad[i, j],2} ");

//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
//             Console.Write("숫자를 입력하세요 (1~25) :");

//             //숫자 입력            
//             int number = int.Parse(Console.ReadLine());

//             bool found = false;
//             for (int i = 0; i < 5; i++)
//             {
//                 for (int j = 0; j < 5; j++)
//                 {
//                     if (boad[i, j] == number)
//                     {
//                         marked[i, j] = true;
//                         found = true;
//                         break;
//                     }
//                 }
//                 if (found) break;
//             }

//             //빙고 개수 체크
//             bingoCount = 0;

//             //가로 체크
//             for (int i = 0; i < 5; i++)
//             {
//                 bool rowBingo = true;
//                 for (int j = 0; j < 5; j++)
//                 {
//                     if (!marked[i, j]) rowBingo = false;
//                 }
//                 if (rowBingo) bingoCount++;

//             }

//             //세로체크
//             for (int j = 0; j < 5; j++)
//             {
//                 bool colBingo = true;

//                 for (int i = 0; i < 5; i++)
//                 {
//                     if (!marked[i, j]) colBingo = false;
//                 }
//                 if (colBingo) bingoCount++;
//             }

//             //대각선 체크

//             bool diag1Bingo = true;
//             for (int i = 0; i < 5; i++)
//             {
//                 if (!marked[i, i]) diag1Bingo = false;

//             }
//             if (diag1Bingo) bingoCount++;

//             bool diag2Bingo = true;
//             for (int i = 0; i < 5; i++)
//             {
//                 if (!marked[i, 4 - i]) diag2Bingo = false;
//             }

//             if (diag2Bingo) bingoCount++;
//         }

//         Console.WriteLine("빙고 5개 완성! 게임 종료");


//     }
// }



