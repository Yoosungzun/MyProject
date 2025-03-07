// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection.PortableExecutable;
// using System.Text;
// using System.Threading.Tasks;

// namespace study5
// {
//     class Program
//     {
//         static void Main (string[] args)
//         {
//             //로딩바 시작 화면
//             //게임스토리1
//             int countdown = 180;

//             while (countdown > 0)
//             {
//                 Console.Clear();
//                 Console.WriteLine($"로딩 남은 시간 : {countdown}초");
//                 Thread.Sleep(20);
//                 countdown --;
//             }

//             Console.Clear();
//             Console.WriteLine("오후 11: 57분");
//             Console.ReadLine();
//             Console.WriteLine("3분 후 , 당신은 죽는다.");
//             Console.ReadLine();
//             Console.WriteLine("이미 수십 번 이 순간을 반복 했다");
//             Console.ReadLine();
//             Console.WriteLine("언제나 실패 했고 언제 까지 기회가 있을지 모른다.");
//             Console.ReadLine();
//             Console.WriteLine("느낌이 말한다 이번이 마지막 기회라고");
//             Console.ReadLine();
//             Console.WriteLine("주변을 둘러본다.");
//             Console.ReadLine();
//             Console.WriteLine("당신은 이제 선택을 해야 한다.");
//             Console.WriteLine("1.책상 서랍을 연다");
//             Console.WriteLine("2.문을 강제로 열어본다");
//             Console.WriteLine("3.거울을 본다");
//             Console.WriteLine("4.눈을 감고 카운트 다운을 기다린다다");
//             Console.Write("무슨 행동을 할까? : ");
//             string? choice = Console.ReadLine() ?? "";

//             switch (choice)
//             {
//                 case "1":
//                     Option1();
//                     break;
//                 case "2":
//                     Option2();
//                     break;
//                 case "3":
//                     Option3();
//                     break;
//                 case "4":
//                     Option4();
//                     break;
//                 default:
//                     Console.WriteLine("\n 올바른 선택을 입력하세요.");
//                     Thread.Sleep(1000);
//                     break;
//             }

//         }

//         static void Option1()
//         {
//             Console.Clear();
//             Console.WriteLine("책상 서랍을 연다.");
//             Console.WriteLine("서랍을 열자, 안에는 낡은 일기장과 작은 열쇠가 들어 있다.");
//             Console.WriteLine("일기장을 펼쳐 보니… 당신이 직접 쓴 것이다.");
//             Console.WriteLine("\"나는 04:00이 되면 사라진다. 해결책은…\"");
//             Console.WriteLine("다음 페이지가 찢겨 나가 있다.");
//         }

//         static void Option2()
//         {
//             Console.Clear();
//             Console.WriteLine("문을 강제로 열어본다");
//             Console.WriteLine("문고리를 돌리려 하지만, 안에서 잠겨 있다.");
//             Console.WriteLine("당신은 힘껏 문을 밀지만 열리지 않는다.");
//             Console.WriteLine("03:59 → 시간이 거의 다 됐다.");
//             Console.WriteLine("벽 너머에서 누군가 속삭인다.");
//             Console.WriteLine("\"넌 아직 답을 모르는구나.\"");
//         }
//         static void Option3()
//         {
//             Console.Clear();
//             Console.WriteLine("거울을 본다");
//             Console.WriteLine("거울 속에 비친 당신의 모습이 이상하다.");
//             Console.WriteLine("얼굴이 점점 흐려진다.");
//             Console.WriteLine("손을 내밀어 거울을 만지자, 차가운 감촉이 느껴진다.");
//             Console.WriteLine("그 순간—거울 속의 ‘당신’이 속삭인다.");
//             Console.WriteLine("\"여긴 네가 있어야 할 곳이 아니야.\"");
//         }

//         static void Option4()
//         {
//             Console.Clear();
//             Console.WriteLine(" 눈을 감고 카운트다운을 기다린다");
//             Console.ReadLine();
//             Console.WriteLine("03:59...");
//             Console.ReadLine();
//             Console.WriteLine("04:00.");
//             Console.ReadLine();
//             Console.WriteLine("—정적.");
//             Console.ReadLine();
//             Console.WriteLine("\n눈을 뜨니… 당신은 다른 방에 있다.");
//             Console.ReadLine();
//             Console.WriteLine("그곳에는 또 다른 ‘당신’이 앉아 있다.");
//             Console.ReadLine();
//             Console.WriteLine("\"이번엔 어디까지 왔어?\"");
//             Console.ReadLine();            
//             Console.WriteLine("\n게임이 종료되었습니다.");
//         }

//     }
// }