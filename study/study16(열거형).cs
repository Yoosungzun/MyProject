// using System;
// using System.Globalization;

// class Program
// {
//     //열거형이란?
//     //Enumeration enum
//     //숫자 값에 이름을 부여하는 자료형
//     //가독성을 높이고, 의미 있는 값으로 표현 가능
//     //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

//     //기본적이 enum 사용법

//     enum DayOfWeek
//     {
//         Sunday,
//         Monday,
//         Tuesday,
//         Wednesday,
//         Thursday,
//         Friday,
//         Saturday

//     }

//     //2.enum 값 변경 (0부터 시작하지 않기)

//     enum StatusCode
//     {
//         Success = 200,
//         BadRequest = 400,
//         Unauthorized = 401,
//         NotFound = 404
//     }

//     enum WeaponType
//     {
//         Sword,
//         Bow,
//         Staff
//     }


//     static void Main(string[] args)
//     {
//         // DayOfWeek today = DayOfWeek.Wednesday;

//         // Console.WriteLine(today);
//         // Console.WriteLine((int)today);

//         // StatusCode status = StatusCode.NotFound;

//         // Console.WriteLine(status);
//         // Console.WriteLine((int)status);


//         //열거형과 함수를 이용해서 풀어주세요.
//         //WeaponType.Sword 검을 선택했습니다.

//         //ChooseWeapon(weaponType.Bow); // 출력 : 활을 선택했습니다.

//         ChooseWeapon(WeaponType.Bow);

//     }

//     static void ChooseWeapon(WeaponType weapon)
//     {
//         // string weaponName = weapon switch
//         // {
//         //     WeaponType.Sword => "검",
//         //     WeaponType.Bow => "활",
//         //     WeaponType.Staff => "스태프"
//         // };

//         // Console.WriteLine($"{weaponName}을 선택했습니다.");

//         if (weapon == WeaponType.Sword)
//         {
//             Console.WriteLine("검을 선택했습니다.");
//         }
//         else if (weapon == WeaponType.Bow)
//         {
//             Console.WriteLine("활을 선택했습니다.");
//         }
//         else if (weapon == WeaponType.Staff)
//         {
//             Console.WriteLine("스태프프을 선택했습니다.");
//         }
//     }
// }