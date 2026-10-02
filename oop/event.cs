// namespace Hello
// {

    // class Program
    // {
        // class Car
        // {
        //     public string? Model;
        //     public void viewCar()=>Console.WriteLine($"{Model} is my car");
        // }
        // public static void Main(string[] args)
        // {
        //     Car myCar=new Car();
        //     myCar.Model="BYD";
        //     myCar.viewCar();
        // }

        

        //polymorphism==dynamic polymorphism==run time polymorphisn=method==overriding

    //     class Vehicle
    //     {
    //         public virtual void Run(){}
    //     }

    //     class Car:Vehicle
    //     {
    //         public override void Run()
    //         {
    //             Console.WriteLine("Car is running");
    //         }
    //     }

    //     class Bus:Vehicle
    //     {
    //         public override void Run()
    //         {
    //             Console.WriteLine("Bus is running");
    //         }
    //     }

    //     public static void Main(string[] args)
    //     {
    //         Car c1=new Car();
    //         c1.Run();
    //         Bus b1=new Bus();
    //         b1.Run();
    //     }



    //override vs new

    // public class BaseClass
    //     {
    //         public virtual void Print()
    //         {
    //             Console.WriteLine("Base class");
    //         }
    //     }

    // public class Derived : BaseClass
    //     {
    //         public override void Print()
    //         {
    //             Console.WriteLine("Derived class");
    //         }
    //     }
        
    // public static void Main(string[] args)
    //     {
    //         BaseClass baseClass=new Derived();
    //         baseClass.Print();

    //         // Derived derived=new Derived();
    //         // derived.Print();

            
    //     }

        // delegate int MathOp(int a, int b);

        // public static void Main(string[] args)
        // {
            
        //     int Add(int a,int b)=>a+b;
        //     int Multiply(int a,int b)=>a*b;


        //     MathOp op=Add;
        //     Console.WriteLine(op(3,4));

        //     MathOp op1=Multiply;
        //     Console.WriteLine(op1(5,5));



        // }



        // delegate int MathOp(int a, int b);

        // public static void Main(string[] args)
        // {
        //     int Calculate(int a, int b, MathOp operation)
        //     {
        //         return operation(a,b);
        //     }


        //     int Add(int a,int b)=>a+b;
        //     int Multiply(int a,int b)=>a*b;

        //     Console.WriteLine(Calculate(3,4,Add));
        //     Console.WriteLine(Calculate(5,6,Multiply));
        // }






        //Events

        //pub-sub wrapper around the delegate, allows class to notify subscribers when something changes, use events instead of the delegates because
        //it does not allows the outside code to invoke or override directly just like the delegate allows



        // public delegate void BookingHandler(string message);//delegate

        // public class BookingService
        // {
        //     public event BookingHandler? BookingCompleted; //declaring an event

        //     public void BookTicket()
        //     {
        //         Console.WriteLine("Booking Successfull");

        //         BookingCompleted?.Invoke("Ticket Booked successfully"); //publisher raising the notification
        //     }

        // };

        // class Program{
        //     static void Main()
        //     {
        //         BookingService bookingService=new BookingService();

        //         bookingService.BookingCompleted+=SendEmail; //subscribing to the event;
        //         bookingService.BookingCompleted+=SendSms;

        //         bookingService.BookTicket();
        //     }

        //  static void SendEmail(string message)
        // {
        //     Console.WriteLine("Email"+message);
        // }

        // static void SendSms(string message)
        // {
        //     Console.WriteLine("Sms"+message);
        // }



        // }


    //generics


        //class===uses the reference type while comparing

        // public class Person
        // {
        //     public string? Name{get;set;}
        //     public int Age{get;set;}

        //     public Person(string name, int age)
        //     {
        //         Name=name;
        //         Age=age;
        //     }
        // }

        // public static void Main(string[] args)
        // {
        //     Person person=new Person("Ram",22);
        //     Person person1=new Person("Ram",22);


        //     Console.WriteLine(person==person1);
        // }


        //record==uses the value type while comparing

        // public record Person(string Name,int Age);

        // public static void Main(string[] args)
        // {
        //     Person person1=new Person("Ram",22);
        //     Person person2=new Person("Ram",22);

        //     Console.WriteLine(person1==person2);
        // }

    
// }