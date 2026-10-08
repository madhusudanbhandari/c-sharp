//1.Singleton design patten==create a single instance of the class and allow a global access to it


// namespace Hello
// {
//     class Program
//     {
//         public class AppConfiguration
//         {
//             private static AppConfiguration? _instance;

//             private AppConfiguration()
//             {

//             }

//             public static AppConfiguration Instance
//             {
//                 get
//                 {
//                     if (_instance == null)
//                     {
//                         _instance=new AppConfiguration();
//                     }

//                     return _instance;
//                 }
//             }

//             public string ApplicationName{get;set;}="MyPro";
//         }

//         public static void Main(string[] args)
//         {
//             var config1=AppConfiguration.Instance;
//             var config2=AppConfiguration.Instance;

//             Console.WriteLine(config1.ApplicationName);

//             Console.WriteLine(ReferenceEquals(config1,config2));
//         }
//     }
// }





//2. Factory Design Pattern==instead of instantiating the object directly with the new keyword we delegate the responsibility of creating new object to the specialized factory method


// namespace Hello
// {
//     class Program
//     {
//         public interface INotification
//         {
//          void Send(string message);
//         }

//         public class EmailNotification : INotification
//         {
//             public void Send(string message)
//             {
//                 Console.WriteLine($"Email Message:{message}");
//             }
//         }

//         public class SmsNotification : INotification
//         {
//             public void Send(string message)
//             {
//                 Console.WriteLine($"SMS Message:{message}");
//             }
//         }

//         public class PushNotification : INotification
//         {
//             public void Send(string message)
//             {
//                 Console.WriteLine($"Push Message:{message}");
//             }
//         }


//         public class NotificationFactory
//         {
//             public  INotification Notification(string type)
//             {
//                 return type.ToLower() switch
//                 {
//                     "email"=> new EmailNotification(),
//                     "sms"=>new SmsNotification(),
//                     "push"=> new PushNotification(),
//                     _=> throw new ArgumentException("Ivalid notification choice")
//                 };
//             }
//         }

//         public static void Main(string[] args)
//         {
//             var factory=new NotificationFactory();

//             var notification=factory.Notification("sms");

//             notification.Send("This is a sms");
//         }
//     }
// }



//3.Abstract Factory...Creates the family of the related objects


// namespace Hello
// {
//     class Program
//     {
//         public interface IPaymentProcessor
//         {
//             void Pay(decimal amount);
//         }

//         public interface IReceiptGenerator
//         {
//             void Generate();
//         }

//         public class EsewaPayment : IPaymentProcessor
//         {
//             public void Pay(decimal amount)
//             {
//                 Console.WriteLine($"{amount} payed using esewa");
//             }

//         }

//         public class EsewaReceipt : IReceiptGenerator
//         {
//             public void Generate()
//             {
//                 Console.WriteLine("Receipt generated using the esewaa");
//             }
//         }

//         public class KhaltiPayment : IPaymentProcessor
//         {
//             public void Pay(decimal amount)
//             {
//                 Console.WriteLine($"{amount} payed using the khalti");
//             }
//         }

//         public class KhaltiReceipt : IReceiptGenerator
//         {
//             public void Generate()
//             {
//                 Console.WriteLine("Generated using the khalti");
//             }
//         }

//         public interface IPaymentFactory
//         {
//             IPaymentProcessor CreatePaymentProcessor();
//             IReceiptGenerator CreateReceiptGenerator();
//         }

//         public class EsewaFactory : IPaymentFactory
//         {
//             public IPaymentProcessor CreatePaymentProcessor()
//             {
//                 return new EsewaPayment();
//             }

//             public IReceiptGenerator CreateReceiptGenerator()
//             {
//                 return new EsewaReceipt();
//             }
//         }

//         public class KhaltiFactory : IPaymentFactory
//         {
//             public IPaymentProcessor CreatePaymentProcessor()
//             {
//                 return new KhaltiPayment();
//             }

//             public IReceiptGenerator CreateReceiptGenerator()
//             {
//                 return new KhaltiReceipt();
//             }

//         }


//         public static void Main(string[] args)
//         {
//             IPaymentFactory paymentFactory=new EsewaFactory();
//             IPaymentFactory paymentFactory1=new KhaltiFactory();

//             var payment=paymentFactory.CreatePaymentProcessor();
//             var receipt=paymentFactory.CreateReceiptGenerator();

//             var payment1=paymentFactory1.CreatePaymentProcessor();
//             var receipt1=paymentFactory1.CreateReceiptGenerator();

//             payment.Pay(500);

//             receipt.Generate();


//             payment1.Pay(1000);
//             receipt1.Generate();
//         }
//     }
// }




//4. Builer Design Pattern====instead of creating the entire complicated object at once...we have to create the object one by one

// namespace Hello
// {
//     class Program
//     {
//         public class Employee
//         {
//             public string Name{get;set;}="";
//             public string Email{get;set;}="";
//             public int Age{get;set;}
//         }

//         public class EmployeeBuilder
//         {
//             private Employee _employee=new Employee();

//             public EmployeeBuilder SetName(string name)
//             {
//                 _employee.Name=name;
//                 return this;
//             }

//             public EmployeeBuilder SetEmail(string email)
//             {
//                 _employee.Email=email;
//                 return this;
//             }
            
//             public EmployeeBuilder SetAge(int age)
//             {
//                 _employee.Age=age;
//                 return this;
//             }

//             public Employee Build(){
//                 return _employee;
//             }
//         }

//         public static void Main(string[] args)
//         {
//             var employee=new EmployeeBuilder()
//                         .SetName("Ram")
//                         .SetEmail("ram@gmil.com")
//                         .SetAge(22)
//                         .Build();


//             Console.WriteLine(employee.Name);
//             Console.WriteLine(employee.Age);
//         }
//     }
// }