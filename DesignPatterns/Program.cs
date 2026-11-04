//Behavioural Design Patterns

//1.Adapter design pattern==helps the multiple objects and classes to combine to form large,flexible structure using the adapter class
//adapter class implements the innterface that out application expects
//adapter helps to make the third party apis or the sdks compatible


// namespace Hello
// {
//     class Program
//     {
//         public interface IPaymentService //target==interface our code/client expects
//         {
//             public Task<bool> ProcessPayment(decimal amount);
//         }

//         public class KhaltiSdk //adaptee==third party sdk that need to be made compatible 
//         {
//             public Task<bool> MakePayment(decimal amount)
//             {
//                 Console.WriteLine($"{amount} paid via khalti");

//                 return Task.FromResult(true);
//             }
//         }

//         public class KhaltiAdapter : IPaymentService //adapter==helps to make the third party interface compatible
//         {
//             private readonly KhaltiSdk _khaltiSdk;

//             public KhaltiAdapter(KhaltiSdk sdk)
//             {
//                 _khaltiSdk=sdk;
//             }

//             public Task<bool> ProcessPayment(decimal amount)
//             {
//                 return _khaltiSdk.MakePayment(amount);

//             }
//         }

//         static void Main(string[] args)
//         {
//             KhaltiSdk sdk=new KhaltiSdk();
//             KhaltiAdapter adapter=new KhaltiAdapter(sdk); //client==the code that expects the interface

//             adapter.ProcessPayment(4000);
//         }
//     }
// }




//2.Decorator pattern==allows us to add the additional behaviours and responsibilities to existing object dynamically 
//  without modifying the original class

//below we added the logging on top of the payment processing


// namespace Hello
// {
//     class Program
//     {
//         public interface IPaymentService
//         {
//             public Task<bool> ProcessPayment(decimal amount);
//         }

//         public class PaymentService : IPaymentService
//         {
//             public async Task<bool> ProcessPayment(decimal amount)
//             {
//                 Console.WriteLine("Processing payment");

//                 await Task.Delay(5000);

//                 Console.WriteLine("Processed");

//                 return true;
//             }
//         }

//         public class PaymentLoggingDecorator : IPaymentService
//         {
//             private readonly IPaymentService _paymentService;
//             public PaymentLoggingDecorator(IPaymentService paymentService)
//             {
//                 _paymentService=paymentService;
//             }

//             public async Task<bool> ProcessPayment(decimal amount)
//             {
//                 Console.WriteLine("Payment operation started");

//                 var result=await _paymentService.ProcessPayment(amount);

//                 Console.WriteLine("Payment operation completed");

//                 return result;
//             }
//         }

//         static async Task Main(string[] args)
//         {
//             IPaymentService payment=new PaymentService();
//             payment=new PaymentLoggingDecorator(payment);
//             await payment.ProcessPayment(5000);
//         }
//     }
// }