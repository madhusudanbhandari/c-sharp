// //class and object

// using System.Text;

// namespace oop
// {
//     class Program
//     {
//         //1.class and objects

//         // class Student
//         // {
//         //     public string? Name{get;set;}
//         //     public int Age{get;set;}

//         //     public Student(string name,int age)
//         //     {
//         //         Name=name;
//         //         Age=age;
//         //     }

//         //     public void IsTopper(string ans)
//         //     {
//         //         Console.WriteLine($"{Name} is {ans}");
//         //     }

//         // }
//         // static void Main(string[] args)
//         // {
//         //     Student s1=new Student("Hari",22);
//         //     Student s2=new Student("sita",23);
//         //     // s1.Name="Ram";
//         //     // s1.Age=23;


//         //     Console.WriteLine($"The name is {s1.Name}, and age is {s1.Age}");
//         //     Console.WriteLine($"The name is {s2.Name}, and age is {s2.Age}");

//         //     s1.IsTopper("Topper");
//         //     s2.IsTopper("Not a topper");


//         // }



//         //2. Encapsulation

//     //     class BankAccount
//     //     {
//     //         public string? Name{get;set;}
//     //         public decimal Balance{get; private set;}

//     //         public void DepositMoney(int amnt)
//     //         {
//     //             Balance+=amnt;
//     //         }

//     //         public void WithdrawMoney(int amnt)
//     //         {
//     //             Balance-=amnt;
//     //         }
//     //     }

//     //     public static void Main(string[] args)
//     //     {
//     //         BankAccount bankAccount1=new BankAccount();
//     //         bankAccount1.DepositMoney(50000);
//     //         Console.WriteLine($"Balance is {bankAccount1.Balance}");
//     //         bankAccount1.WithdrawMoney(2000);
//     //         Console.WriteLine($"Balance is {bankAccount1.Balance}");


//     //     }
    

//     //3.abstraction

//     // public interface IPaymentService
//     //     {
//     //         public void Pay(int amnt)
//     //         {
//     //             Console.WriteLine($"{amnt} payed to user");
//     //         }
//     //     }

//     // class IMEPayment : IPaymentService
//     //     {
//     //         public void Pay(int amn)
//     //         {
//     //             Console.WriteLine($"{amn} payed via ime");
//     //         }

//     //     }

//     // class EsewaPayment : IPaymentService
//     //     {
//     //         public void Pay(int amnt)
//     //         {
//     //             Console.WriteLine($"{amnt} payed via esewa");
//     //         }
//     //     }


//     // public static void Main(string[] args)
//     //     {
//     //         IPaymentService payment=new EsewaPayment();
//     //         payment.Pay(3000);
//     //         IPaymentService payment1=new IMEPayment();
//     //         payment1.Pay(1000);
//     //     }


//     //4.Inheritence

//     // class Animal
//     //     {
//     //         public string? Name{get;set;}
//     //         public void MakeSound()
//     //         {
//     //             Console.WriteLine("Animal makes sound");
//     //         }

//     //     }
    
//     // class Dog : Animal
//     //     {
//     //         public void  MakeSound1()
//     //         {
//     //             Console.WriteLine("Bow bow");
//     //         }
//     //     }

//     // public static void Main(string[] args)
//     //     {
//     //         Dog dog=new Dog();
//     //         dog.MakeSound();
//     //         dog.MakeSound1();
            
//     //     }


//     //5.Polymorphism

//     // public  class Payment
//     //     {
//     //         public virtual void Pay()
//     //         {
//     //             Console.WriteLine("Payment");
//     //         }
//     //     }

//     // public class EsewaPay : Payment
//     //     {
//     //         public override void Pay()
//     //         {
//     //             Console.WriteLine("Paying via esewa");
//     //         }
//     //     }

//     // public class KhaltiPay : Payment
//     //     {
//     //         public override void Pay()
//     //         {
//     //             Console.WriteLine("Payed via khalti");
//     //         }
//     //     }
    
//     // public static void Main(string[] args)
//     //     {
//     //         Payment esewaPay=new EsewaPay();
//     //         esewaPay.Pay();
//     //         Payment khaltiPay=new KhaltiPay();
//     //         khaltiPay.Pay();
//     //     }

//     //6.static vs instance
    
//     // class Example
//     //     {
//     //         public static void Method1()
//     //         {
//     //             Console.WriteLine("This is method 1");
//     //         }

//     //         public void Method2()
//     //         {
//     //             Console.WriteLine("This is a method 2");
//     //         }

//     //     }

//     //     public static void Main(string[] args)
//     //     {
//     //         Example example=new Example();
//     //         example.Method2();
//     //         Example.Method1();
//     //     }



//     //6.Collections

//     //1.array==fixed size storage, of same type

//     // public static void Main(string[] args)
//     //     {
//     //         int[] nums={1,2,3,4,5,5};
//     //         string[] names=new string[3];

//     //         names[0]="ram";
//     //         names[1]="hari";
//     //         names[2]="hari";

//     //         foreach(int num in nums)
//     //         {
//     //             Console.WriteLine(num);
//     //         }

//     //         foreach(string name in names)
//     //         {
//     //             Console.WriteLine(name);
//     //         }
//     //     } 


//     //2.List==dynamic collection with no fixed size

//     // public static void Main(string[] args)
//     //     {
//     //         List<int> nums=[1,2,3,4,5,5];
//     //         nums.Add(6);
//     //         nums.Remove(5);
//     //         foreach(int num in nums)
//     //         {
//     //             Console.WriteLine(num);
//     //         }
        
//     //     }

//     //dictionary =holds the key value pair
    
//     // public static void Main(string[] args)
//     //     {
//     //         Dictionary<int,string> students=new();

//     //         students.Add(1,"Ram");
//     //         students.Add(2,"hari");
//     //         students.Add(3,"sita");
//     //         students.Add(4,"Gita");

//     //         for(int i=1; i<5; i++)
//     //         {
//     //             Console.WriteLine(students[i]);
//     //         }

//     //        if(students.TryGetValue(2,out var name))
//     //         {
//     //             Console.WriteLine(name);
//     //         }

//     //     }



//     //Generics
    
//     //allow you to write a piece of code that can run with the multiple types still being the type safe

//     // class Box
//     //     {
//     //         public object? Value{get;set;}
//     //     }

//     //     public static void Main(string[] args)
//     //     {
//     //         Box box=new Box();
//     //         box.Value=1;
//     //         // box.Value="ram";

//     //         Console.WriteLine(box.Value);
//     //     }


//     // public class Box<T>
//     //     {
//     //         public T? Value{get;set;}
//     //     }

//     //     public static void Main(string[] args)
//     //     {
//     //         Box<int> numberBox=new();
//     //         numberBox.Value=12;


//     //         Box<string> stringBox=new();
//     //         stringBox.Value="ram";


//     //     }




//     //Delegates==delegate is a type safe variable that can hold the reference to a method

//     // delegate void MyDelegate();

//     // public static void Main(string[] args)
//     //     {
//     //         void sayHello()
//     //         {
//     //             Console.WriteLine("hello");
//     //         }

//     //         MyDelegate d=sayHello;

//     //         d();
//     //     }


    






//     //String and stringbuilder

//     public static void Main(string[] args)
//         {
//         //     string result="";

//         //     for(int i = 0; i < 100; i++)
//         //     {
//         //         result+=i.ToString();
//         //     }

//         //     Console.WriteLine(result);


//         //string builder

//         // var sb=new StringBuilder();
//         // for(int i = 0; i < 10; i++)
//         //     {
//         //         sb.Append(i);
//         //     }

//         //     string result=sb.ToString();
//         //     Console.WriteLine(result);
//         // }
        
        
//         //Arrays
        
//         //single dimension

//         int[] nums={1,2,3};

//         // //multi dimension

//         // int[,] grid={{1,2,4},{3,4,5}};
//         // Console.WriteLine(grid[1,2]);

//         int[, , ] td={{1,2,3},{4,5,6},{7,8,9}}


//         }
//     }
// }