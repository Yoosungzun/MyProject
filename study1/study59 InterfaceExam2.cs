// using System;
// using InterfaceExam2;

// namespace InterfaceExam2
// {
//     //인터페이스를 사용하면 기존 코드 변경 없이 새로운 기능 추가가 가능함.
//     //다양한 결제 시스템 추가 (Open - Close Principle)

//     interface IPayment
//     {
//         void ProcessPayment();
//     }

//     //신용카드 결제 클래스
//     class CreaditCardPayment : IPayment
//     {
//         public void ProcessPayment()
//         {
//             Console.WriteLine("신용카드 결제 완료!");
//         }
//     }

//     //결제 처리기

//     class PaymentProcessor
//     {
//         public void Pay(IPayment payment)
//         {
//             payment.ProcessPayment();
//         }
//     }

//     class PapalPayment : IPayment
//     {
//         public void ProcessPayment()
//         {
//             Console.WriteLine("페이팔 결제완료료");
//         }
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         PaymentProcessor processor = new PaymentProcessor();

//         IPayment creditCard = new CreaditCardPayment();
//         IPayment paypal = new PapalPayment();

//         processor.Pay(creditCard);
//         processor.Pay(paypal);
//     }
// }