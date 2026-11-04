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



//singleton==a class has single instance throughout the applications lifetime, same instance is shared wherever the class is needed

// namespace Hello
// {
//     class Program
//     {
//         public class DatabaseConnection
//         {
//             private static DatabaseConnection? _instance;
//             private static readonly object _lock=new();
//             private DatabaseConnection()
//             {
//                 Console.WriteLine("Connection created");
//             }

//             public static DatabaseConnection GetInstance()
//             {
//                 lock (_lock) //for thread safety ensures only one object is created during concurrent requests
//                 {

//                     if (_instance == null)
//                     {
//                         _instance=new DatabaseConnection();
//                     }
//                     return _instance;  
//                 }
//             }

//             static void Main(string[] args)
//             {
//                 var db1= DatabaseConnection.GetInstance();
//                 var db2=DatabaseConnection.GetInstance();

//                 Console.WriteLine(ReferenceEquals(db1,db2));

//             }
//         }
//     }
// }

//to implement Singleton in .net ===use DI container, create one instance of the registered service and whenever the instance is requird reuse that



//2.Factory Design Pattern== we dont create the object directly using the new keyword instead we delegate the responsibility of object creation to separate factory class

// namespace Hello
// {
//     class Program
//     {
//         public interface IPaymentService
//         {
//             public void Pay();
//         }

//         public class EsewaPay : IPaymentService
//         {
//             public void Pay()
//             {
//                 Console.WriteLine("Paid via esewa");
//             }
//         }

//         public class KhaltiPay : IPaymentService
//         {
//             public void Pay()
//             {
//                 Console.WriteLine("Paid via khalti");
//             }
//         }

//         public class PaymentFactory
//         {
//             public IPaymentService MakePayment(string type)
//             {
//                 return type.ToLower() switch
//                 {
//                     "esewa"=>new EsewaPay(),
//                     "khalti"=>new KhaltiPay(),
//                     _=>throw new ArgumentException("Wrong payment type")
//                 };
//             }
//         }


//         static void Main(string[] args)
//         {
//             PaymentFactory factory=new PaymentFactory();
//             var khalti=factory.MakePayment("Khalti");
//             khalti.Pay();

//         }
//     }


// }


//3.Abstract Factory Pattern==Create the family of the related objects

// namespace Hello
// {
//     class Example
//     {
//         public interface IStorageService
//         {
//             public void Upload()
//             {
//             }
//         }

//         public interface IEmailService
//         {
//             public void Send(){}
//         }

//         public class AwsStorage : IStorageService
//         {
//             public void Upload()
//             {
//                 Console.WriteLine("Uploaded in aws");
//             }
//         }

//         public class AwsEmail : IEmailService
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Sent via email");
//             }
//         }

//         public class AzureStorage : IStorageService
//         {
//             public void Upload()
//             {
//                 Console.WriteLine("Uploaded in the azure");
//             }


//         }

//         public class AzureEmail : IEmailService
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Sent via azure");
//             }
//         }

//         public interface IAbstractFactory
//         {
//             public IStorageService  StorageService();
//             public IEmailService EmailService();
//         }

//         public class AwsFactory:IAbstractFactory
//         {
//             public IStorageService StorageService()
//             {
//                 return new AwsStorage();
//             } 

//             public IEmailService EmailService()
//             {
//                 return new AwsEmail();
//             }
//         }

//         public class AzureFactory:IAbstractFactory
//         {
//             public IStorageService StorageService()
//             {
//                 return new AzureStorage();
//             }

//             public IEmailService EmailService()
//             {
//                 return new AzureEmail();
//             }
//         }

//         public class CloudService
//         {
//             private readonly IStorageService _storageService;
//             private readonly IEmailService _emailService;

//             public CloudService(IAbstractFactory factory)
//             {
//                 _storageService=factory.StorageService();
//                 _emailService=factory.EmailService();
//             }

//             public void Execute()
//             {
//                 _storageService.Upload();
//                 _emailService.Send();
//             }
//         }

//         static void Main(string[] args)
//         {
//             AwsFactory aws=new AwsFactory();

//             CloudService cloud=new CloudService(aws);
//             cloud.Execute();


//             AzureFactory azure=new AzureFactory();

//             CloudService cloud1=new CloudService(azure);
//             cloud1.Execute();
//         }
//     }
//}


//4.Builder Pattern

//builder pattern allows us to create the object step by step instead of passing all the required parameters in a single constructor

// namespace Hello
// {
//     class Program
//     {
//         public class Course
//         {
//             public string Faculty{get;init;}=string.Empty;
//             public string Subject{get;init;}=string.Empty;
//         }

//         public class CourseBuilder
//         {
//             private string _faculty =string.Empty;
//             private string _subject=string.Empty;

//             public CourseBuilder SetFaculty(string faculty)
//             {
//                 _faculty=faculty;
//                 return this;
//             }
            
//             public CourseBuilder SetSubject(string subject)
//             {
//                 _subject=subject;
//                 return this;
//             }

//             public Course Execute()
//             {
//                 if (string.IsNullOrWhiteSpace(_subject))
//                 {
//                     throw new Exception("Subject must be provider");
//                 }

//                 return new Course
//                 {
//                     Faculty=_faculty,
//                     Subject=_subject
//                 };
//             }

//         }

//         static void Main(string[] args)
//         {
//             var course=new CourseBuilder()
//                         .SetFaculty("Engineering")
//                         .SetSubject("DSA")
//                         .Execute();

//             Console.WriteLine(course.Faculty);

//             Console.WriteLine(course.Subject);
//         }
//     }
// }