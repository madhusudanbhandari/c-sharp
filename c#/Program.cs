// using System;

// namespace Hello
// {
//     class Program
//     {
//         public class BankAccount
//         {
//             public string Name{get;set;}=string.Empty;
//             public decimal Balance{get;private set;}


//             public BankAccount(string Name, decimal Balance)
//             {
//                 this.Name=Name;
//                 this.Balance=Balance;
//             }

//             public void Deposit(decimal amount)
//             {
//                 if (amount <= 0)
//                 {
//                     throw new Exception("Cannot deposit 0 or below");
//                 }

//                 Balance+=amount;
//                 Console.WriteLine($"{amount} deposited and new balance is{Balance}");
//             }

//             public void Withdraw(decimal amount)
//             {
//                 if (amount <= 0)
//                 {
//                     throw new Exception("Cannot withdraw 0 or below");
//                 }

//                 if (amount > Balance)
//                 {
//                     throw new Exception("Cannot withdraw more than the available balance");
//                 }

//                 Balance-=amount;
//                 Console.WriteLine($"{amount} withdrawn and new balance is{Balance}");

//             }

//         }

//       public static void Main(string[] args)
//         {
//             BankAccount account=new BankAccount("Ram",4000);

//             account.Deposit(3000);
//             account.Withdraw(9000);
//         }

//     }

// }





//2.


// namespace Hello
// {
//     class Program
//     {
//         public class Course
//         {
//             public int Id{get;set;}
//             public string Name{get;set;}=string.Empty;
//             public int MaximumMarks{get;set;}
//             public Student? Student{get;set;}

//             public Course(int id, string name,int mm)
//             {
//                 this.Id=id;
//                 this.Name=name;
//                 this.MaximumMarks=mm;
//             }
//         }
//         public class Student
//         {
//             public int Id{get;set;}
//             public string Name{get;set;}=string.Empty;
//             public int Marks{get;set;}

//             public ICollection<Course> Courses{get;set;}=new List<Course>();
//             public int CourseId{get;set;}

//             public Student(int Id,string Name,int Marks,int courseId)
//             {
//                 this.Id=Id;
//                 this.Name=Name;
//                 this.Marks=Marks;
//                 this.CourseId=courseId;
//             }



//         }
//         public static void Main(string[] args)
//         {
//            Course course=new Course(1,"Math",100);
//            Course course1=new Course(2,"English",100);
//            Course course2=new Course(3,"Science",100);

//            Student student=new Student(1,"Ram",55,1);
//            student.Courses.Add(course);
//            student.Courses.Add(course1);
//            student.Courses.Add(course2);

//            foreach(var c in student.Courses)
//             {
//                 Console.WriteLine(c.Name);
//             }

//             double average=student.


//         }
//     }
// }



//

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Hello
// {
//     class Program
//     {
//         public class Product
//         {
//             public int Id { get; set; }
//             public string Name { get; set; } = string.Empty;
//             public decimal Price { get; set; }

//             public Product(int id, string name, decimal price)
//             {
//                 Id = id;
//                 Name = name;
//                 Price = price;
//             }
//         }

//         public class CartItem
//         {
//             public Product Product { get; set; }
//             public int Quantity { get; set; }

//             public decimal Subtotal => Product.Price * Quantity;

//             public CartItem(Product product, int quantity)
//             {
//                 Product = product;
//                 Quantity = quantity;
//             }
//         }

//         public class ShoppingCart
//         {
//             public int Id { get; set; }

//             public List<CartItem> CartItems { get; set; }
//                 = new List<CartItem>();

//             public void AddProduct(Product product, int quantity)
//             {
//                 var existingItem = CartItems
//                     .FirstOrDefault(item => item.Product.Id == product.Id);

//                 if (existingItem != null)
//                 {
//                     existingItem.Quantity += quantity;
//                 }
//                 else
//                 {
//                     CartItems.Add(new CartItem(product, quantity));
//                 }
//             }

//             public decimal CalculateTotal()
//             {
//                 return CartItems.Sum(item => item.Subtotal);
//             }

//             public void DisplayCart()
//             {
//                 foreach (var item in CartItems)
//                 {
//                     Console.WriteLine(
//                         $"{item.Product.Name} x {item.Quantity} = {item.Subtotal}");
//                 }

//                 Console.WriteLine($"Total price: {CalculateTotal()}");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Product product = new Product(1, "Biscuit", 230m);
//             Product product1 = new Product(2, "Sugar", 130m);

//             ShoppingCart shoppingCart = new ShoppingCart();

//             shoppingCart.AddProduct(product, 5);
//             shoppingCart.AddProduct(product1, 2);
//             shoppingCart.AddProduct(product, 1);

//             shoppingCart.DisplayCart();
//         }
//     }
// }



//value type vs reference type

// namespace Hello
// {
//     class Program
//     {
//         class Student
//         {
//             public int Id{get;set;}
//             public string Name{get;set;}=string.Empty;

//             public Student(int id,string name)
//             {
//                 Id=id;
//                 Name=name;
//             }
//         }
//         public static void Main(string[] args)
//         {
//             //value type
//             int a=5;
//             int b=6;
//             Console.WriteLine(a);
//             Console.WriteLine(b);
//             b=a; 
//             a=4;//value type copies the value of the one variable to another
//             Console.WriteLine(b); //5
//             Console.WriteLine(a);

//             //reference type
//             //assignment
//             Student student=new Student(1,"Ram");
//             Student student1=new Student(2,"Hari");

//             Console.WriteLine("Before modification");
//             Console.WriteLine(student.Name);
//             Console.WriteLine(student1.Name);

//             //after modification

//             student1=student; 

//             student.Name="Sita";
//             Console.WriteLine(student.Name);
//             Console.WriteLine(student1.Name);



//         }
//     }
// }


//ref,out,in parameters===controls how the arguments are passed to the method

// namespace Hello
// {
//     class Example
//     {
//         public static void Main(string[] args)
//         {

//ref allows method to change the existing variable,with ref the method can read and change the callers value iteslf
// void ChangeNumber(ref int number)
// {
//     number=100;
// }

// int x=10;
// ChangeNumber(ref x);
// Console.WriteLine(x);






//         }
//     }
// }





//method overriding vs method overloading

//method overriding===replacing the existing implementation with the new one

// namespace Hello
// {
//     class Program
//     {
//         public class User
//         {
//             public int Id{get;set;}
//             public string Name{get;set;}=string.Empty;

//             public User(int id,string name)
//             {
//                 Id=id;
//                 Name=name;
//             }

//             public virtual void Display()
//             {
//                 Console.WriteLine($"Name:{Name}");
//             }
//         }

//         public class Employee : User
//         {
//             public string Role{get;set;}=string.Empty;

//             public Employee(int id, string name,string role) : base(id, name)
//             {
//                 Id=id;
//                 Name=name;
//                 Role=role;
//             }

//             public override void Display()
//             {
//                 Console.WriteLine($"name is {Name}");
//                 base.Display();
//             }



//         }

//         public static void Main(string[] args)
//         {
//             User user=new User(1,"Sita");
//             user.Display();

//             Employee employee=new Employee(1,"Ram","Employee");
//             employee.Display();


//         }
//     }
// }


//method overloading===providing different implementation for the same method with different number and type of the parameters


// namespace Hello
// {
//     class Program
//     {
//         public class Student
//         {
//             public void Display(int id,string name)
//             {
//                 Console.WriteLine($"Stuent Id:{id} and Name:{name}");
//             }

//             public void Display(int id,string name,int age)
//             {
//                 Console.WriteLine($"{id}, {name},{age}");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Student student=new Student();
//             student.Display(1,"ram",34);
//         }

//     }
// }



//polymorphism==same method behaves differently based on the object used


// namespace Hello
// {
//     class Program
//     {
//         public abstract class Payment
//         {
//             public abstract void Pay(decimal amount);
//         }

//         public class EsewaPayment : Payment
//         {
//             public override void Pay(decimal amount)
//             {
//                 Console.WriteLine($"Payed {amount} via esewa");
//             }
//         }

//         public class KhaltiPayment : Payment
//         {
//             public override void Pay(decimal amount)
//             {
//                 Console.WriteLine($"Payed {amount} via khalti");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EsewaPayment esewaPayment=new EsewaPayment();
//             esewaPayment.Pay(400);

//             Payment khalti=new KhaltiPayment();  //is safe but we can only access the properties defined in the Payment not those of the KhaltiPayment
//             khalti.Pay(500);
//         }
//     }
// }



//abstraction using the interface

// using System.Security.Cryptography.X509Certificates;

// namespace Hello
// {
//     class Program
//     {
//         public interface INotificationService
//         {
//             public void Send(string message);
//         }

//         public class EmailNotificationService : INotificationService
//         {
//             public  void Send(string message)
//             {
//                 Console.WriteLine($"{message} sent via email");
//             }
//         }

//         public class SmsNotificationService : INotificationService
//         {
//             public void Send(string message)
//             {
//                 Console.WriteLine($"{message} sent via sms");
//             }
//         }


//         public class NotificationProvider
//         {
//             private readonly INotificationService _notificationService;

//             public NotificationProvider(INotificationService notificationService)
//             {
//                 _notificationService=notificationService;
//             }


//             public void Notify(string message)
//             {
//                 _notificationService.Send(message);
//             }
//         }


//         public static void Main(string[] args)
//         {
//             INotificationService service=new EmailNotificationService();

//             NotificationProvider provider=new NotificationProvider(service);

//             provider.Notify("hello");
//         }
//     }
// }





//list and array

// using System.Security.Cryptography.X509Certificates;

// namespace Hello
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
// int[] nums={2,3,4,5}; //array is a collection storing fixed elements. of the particular type

// foreach(int num in nums)
// {
//     Console.WriteLine(num);
// }

//List<int> nums=new List<int>();  //dynamic collection of the elements 
//List<int>nums=new(){2,3,4,5};
// nums.Add(6);
// nums.Add(7);
// foreach(int num in nums)
// {
//     if (num % 2 == 0)
//     {
//         nums.RemoveAll();
//     }
//     Console.WriteLine(num);
// }

// nums.RemoveAll(num=>num%2==0);
// Console.WriteLine(nums.Count);

//dictionary

// Dictionary<int, string> Students = new()
// {
//     [1]="Ram",
//     [2]="Hari",
//     [3]="Sita"
// };
// Students.Add(4,"Karna");//throw exception if it already exists
// Students[1]="Alex"; //doesnt throws any exception

// for(int i = 1;i< Students.Count()+1; i++){
//     Console.WriteLine(Students[i]);
// }


//generics


//         }
//     }
// }



//Generics

// namespace Hello
// {
//     class Program
//     {
//         public class Box<T>
//         {
//             public T? Value{get;set;}
//         }

//         public static void Main(string[] args)
//         {
//             Box<int> box=new Box<int>();
//             box.Value=10;

//             Console.WriteLine(box.Value);

//             Box<string> box1=new Box<string>();
//             box1.Value="RAm";
//             Console.WriteLine(box1.Value);
//         }
//     }
// }



//virtual,override vs new

// namespace Hello
// {
//     class Program
//     {
//         public class Animal
//         {
//             public virtual void Speak()
//             {
//                 Console.WriteLine("Animal speaks");
//             }
//         }

//         public class Dog : Animal
//         {
//             public new void Speak()
//             {
//                 Console.WriteLine("Dog speaks");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Dog dog=new Dog();
//             dog.Speak();

//             Animal animal=new Dog();
//             animal.Speak();

//             Animal animal1=new Animal();
//             animal1.Speak();

//         }
//     }
// }




//exception handling

// namespace Hello
// {
//     class Program
//     {
//         public static void Main(string [] args)
//         {
//             int a=34;
//             int b=0;

//             ///int c=a/b;
//             try
//             {
//                 int c=a/b;
//             }catch(DivideByZeroException ex)
//             {
//                 Console.WriteLine($"{ex} occured");
//                 Console.WriteLine($"Message:{ex.Message}");
//                 Console.WriteLine($"Stack trace: {ex.StackTrace}");
//             }
//             Console.WriteLine("Program continues");
//         }
//     }
// }



// //delegate
// using System.Reflection.Metadata;

// namespace Hello
// {
//     class Program
//     {
//         public delegate int Calculation(int a,int b);

//         static int Add(int a,int b)
//         {
//             return a+b;
//         }

//         static int Multiply(int a,int b)
//         {
//             return a*b;
//         }

//         public static void Main(string[] args)
//         {
//             Calculation calculation=Add;
//             Console.WriteLine(calculation(4,5));

//             calculation=Multiply;
//             Console.WriteLine(calculation(5,6));
//         }
//     }
// }


// namespace Hello
// {
//     class Program
//     {
//         public delegate int Calculation(int a,int b);

//         static int Add(int a,int b)
//         {
//             return a+b;
//         }

//         static int Multiply(int a,int b)
//         {
//             return a*b;
//         }

//         static int calculate(int a,int b, Calculation operation)
//         {
//             return operation(a,b);
//         }

//         public static void Main(string[] args)
//         {
//             int sum=calculate(2,3,Add);
//             Console.WriteLine(sum);


//             int mul=calculate(2,3,Multiply);
//             Console.WriteLine(mul);
//         }
//     }
// }

//Hashset==used to hold the unique values removes the duplicates by default

// namespace Hello
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             HashSet<string> Skills =new HashSet<string>
//             {
//                 "C#",
//                 "OOP",
//                 "OOP"
//             };
//             foreach(string skill in Skills)
//             {
//                 Console.WriteLine(skill);
//             }
//         }
//     }
// }

