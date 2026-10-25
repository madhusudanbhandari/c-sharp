//1. Single responsibility principle= a class should have only one reason to change

// //wrong practice
// namespace Hello
// {
//     class Program
//     {
//         public class Register
//         {
//             public void RegisterUser()
//             {
//                 Console.WriteLine("User registered");

//                 Console.WriteLine("Email sent");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Register register=new Register();
//             register.RegisterUser();
//         }
//     }
// }


//right practice


// namespace Hello
// {
//     class Program
//     {
//         public class EmployeeRepository
//         {
//             public void Saved(string name)
//             {
//                 Console.WriteLine($" {name} saved to database");
//             }
//         }

//         public class EmailService
//         {
//             public void Send(string name)
//             {
//                 Console.WriteLine($"email sent to {name}");
//             }
//         }

//         public class EmployeeService: EmployeeRepository
//         {
//             private readonly EmployeeRepository _repository;
//             private readonly EmailService _service;

//             public EmployeeService(EmployeeRepository repository, EmailService service)
//             {
//                 _repository=repository;
//                 _service=service;
//             }

//             public void RegisterEmployee(string name)
//             {
//                 _repository.Saved(name);
//                 _service.Send(name);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EmployeeRepository repository=new EmployeeRepository();
//             EmailService service=new EmailService();

//             EmployeeService employee=new EmployeeService(repository,service);
//             employee.RegisterEmployee("Ram");
//         }
//     }
// }



//2.Open close==a class should be open for extension but closed for modification


// namespace Hello
// {
//     class Program
//     {
//         public class DiscountService
//         {
//             public decimal CalculateDiscount(string customerType,decimal total)
//             {
//                 if (customerType == "Regular")
//                 {
//                     return total*0.20m;
//                 }
//                 else if (customerType == "Normal")
//                 {
//                     return total*0.10m;
//                 }
//                 return 0;
//             }
//         }
//     }
//}



//right approach

// namespace Hello
// {
//     class Program
//     {
//         public interface DiscountStrategy
//         {
//             public decimal CalculateDiscount( decimal total);
//         }

//         public class RegularDiscount : DiscountStrategy
//         {
//             public decimal CalculateDiscount(decimal total)
//             {
//                 return total*0.20m;
//             }
//         }

//         public class NormalDiscount : DiscountStrategy
//         {
//             public decimal CalculateDiscount(decimal total)
//             {
//                 return total*0.10m;
//             }
//         }

//         public class VipDiscount : DiscountStrategy
//         {
//             public decimal CalculateDiscount(decimal total)
//             {
//                 return total*0.30m;
//             }
//         }

//         public static void Main(string[] args)
//         {
//             VipDiscount vip=new VipDiscount();
//             var disc=vip.CalculateDiscount(4000);
//             Console.WriteLine($"you got {disc} discount");

//         }
//     }
// }



//3.Liskov substituition p==an object of the subtype must be used where the object of the base type is expected without breaking the programs expected behaviour

//wrong approach

// namespace Hello
// {
//     class Program
//     {
//         public class Bird
//         {
//             public virtual void Fly(){
//                 Console.WriteLine("Birds can fly");
//             }
//         }

//         public class Sparrow:Bird
//         {

//         }

//         public class Penguin : Bird
//         {
//             public override void Fly()
//             {
//                 throw new InvalidOperationException("Penguins cannot fly");
//             }
//         }

//         public static void MakeBirdFly(Bird bird) //penguin violates this method as it cannot fly
//         {
//             bird.Fly();
//         }

//         public static void Main(string[] args)
//         {
//             Sparrow sparrow=new Sparrow();
//             Penguin penguin=new Penguin();

//             MakeBirdFly(sparrow);
//             MakeBirdFly(penguin); 
//         }
//     }
// }



//Right approach

// namespace Hello
// {
//     class Program
//     {
//         public interface Bird
//         {
//             void Eat();
//         }

//         public interface IFlyingBird
//         {
//             void Fly();
//         }

//         public class Sparrow:Bird, IFlyingBird
//         {
//             public void Eat()
//             {
//                 Console.WriteLine("Sparrow can eat");
//             }

//             public void Fly()
//             {
//                 Console.WriteLine("Sparrow can fly");
//             }
//         }

//         public class Penguin: Bird
//         {
//             public void Eat()
//             {
//                 Console.WriteLine("Penguin can eat");
//             }
//         }

//         public static void MakeBirdFly(IFlyingBird bird). //only the method that implement FlyingBird can be passed
//         {
//             bird.Fly();
//         }

//         public static void Main(string[] args)
//         {
//             Sparrow sparrow=new Sparrow();
//             Penguin penguin=new Penguin();

//             sparrow.Eat();
//             penguin.Eat();


//             MakeBirdFly(sparrow);


//         }
//     }
// }


//4. Interface segregation principle==a class/client should not be forced to depend on the methods that they donot use
//define short and necessary interfaces that avoid creating the unnecessary implementations


//wrong approach

// namespace Hello
// {
//     class Program
//     {
//         public interface EmmployeeService //unecessary implementation of othe methods then sendEmail
//         {
//             public void CreateEmployee();
//             public void DeleteEmployee();
//             public void SendEmail();
//             public void CalculateSalary();
//         }

//         public class EmailService : EmmployeeService
//         {
//             public void CreateEmployee()
//             {
//                 throw new NotImplementedException();
//             }
//             public void DeleteEmployee()
//             {
//                 throw new NotImplementedException();
//             }

//             public void SendEmail()
//             {
//                 Console.WriteLine("Email sent");
//             }

//             public void CalculateSalary()
//             {
//                 throw new NotImplementedException();
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EmailService service=new EmailService();
//             service.SendEmail();
//         }
//     }
// }


//right approach

// namespace Hello
// {
//     class Program
//     {
//         public interface EmployeeRepository
//         {
//             public void SaveEmployee();
//             public void DeleteEmployee();

//         }
//         public interface CalculateSalary
//         {
//             public void SalaryCalculate();
//         }

//         public class EmployeeService : EmployeeRepository
//         {
//             public void SaveEmployee()
//             {
//                 Console.WriteLine("Employee saved");
//             }

//             public void DeleteEmployee()
//             {
//                 Console.WriteLine("Employee deleted");
//             }
//         }

//         public class SalaryService : CalculateSalary
//         {
//             public void SalaryCalculate()
//             {
//                 Console.WriteLine("Salary calculated");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             SalaryService service=new SalaryService();
//             service.SalaryCalculate();
//         }
//     }
// }



//5.Dependency Inversion Principle
//high level modules should not depend on the low level modules both should depend on the abstractions and 
//abstraction should not depend on the implementation and implementation should depend on the abstraction


//wrong approch

// namespace Hello
// {
//     class Program
//     {
//         public class EmailService
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Email sent");
//             }
//         }

//         public class EmployeeService
//         { 
//             private readonly EmailService _emailService=new EmailService();  //bad approach directly creates the email service

//             public void RegisterEmployee()
//             {
//                 Console.WriteLine("Employee registered");

//                 _emailService.Send();
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EmployeeService service=new EmployeeService();
//             service.RegisterEmployee();
//         }
//     }
// }


//right approach

// namespace Hello
// {
//     class Program
//     {
//         public interface IEmailService
//         {
//             void Send();
//         }
//         public class EmailService : IEmailService
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Email sent");
//             }
//         }

//         public class EmployeeService
//         {
//             private readonly IEmailService emailService=new EmailService();

//             public void RegisterEmployee()
//             {
//                 Console.WriteLine("Employee Registered successsfully");

//                 emailService.Send();
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EmployeeService service=new EmployeeService();
//             service.RegisterEmployee();
//         }
//     }
// }