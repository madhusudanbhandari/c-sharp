//Encapsulation==wrapping the data & methods together

//an object should control how its internal state is accessed or changed



//example without encapsulation anyone can change the data
// namespace Hello
// {
//     class Example
//     {
//        public class Account
//     {
//         public decimal Balance;
//     }

//     public static void Main(string[] args)
//         {
//             Account acc=new Account();
//             acc.Balance=50000;
//             Console.WriteLine(acc.Balance);
//             acc.Balance-=40000;
//             Console.WriteLine(acc.Balance);
//         } 
//     }

// }




//with encapsulation==only object can manage its internal state

// namespace Hello
// {
//     class Example
//     {
//         public class Account
//         {
//             public decimal Balance;

//             public void withdrawMoney(decimal amnt)
//             {
//                 Balance-=amnt;
//             }

//             public void depositMoney(decimal amnt)
//             {
//                 Balance+=amnt;
//             }


//         }

//         public static void Main(string[] args)
//         {
//             Account account=new Account();
//             account.depositMoney(3000);
//             Console.WriteLine(account.Balance);

//             account.withdrawMoney(2000);
//             Console.WriteLine(account.Balance);
//         }
//     }
// }



//inheritence
//base is the keyword used to access the parent class methods from the chikd class

// namespace Hello
// {
//     public class Example
//     {
//         public class Employee
//         {
//             public string? Name{get;set;}

//             public void Works()
//             {
//                 Console.WriteLine($"{Name} is working");
//             }

//         }

//         public class Manager : Employee
//         {
//             public void Working()
//             {
//                 base.Works();
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Manager manager=new Manager();
//             manager.Working();
//             manager.Name="Ramm";
//             manager.Working();
//         }
//     }
// }


//constructor and inheritence
//the base portion of the object must be initialized before the derived portion

// namespace Hello
// {
//     class Example
//     {

//         class Animal
//         {
//             public Animal()
//             {
//                 Console.WriteLine("Animal constructor");
//             }
//         }

//         class Dog : Animal
//         {
//             public Dog()
//             {
//                 Console.WriteLine("Dog constructor");
//             }
//         }

//         public static void Main()
//         {
//             Dog dog=new Dog();

//         }

//     }
// }



//calling specific base constructor

// namespace Hello
// {
//     class Example
//     {
//         class Animal
//         {
//             public Animal(string name)
//             {
//                 Console.WriteLine(name);
//             }
//         }

//         class Dog : Animal
//         {
//             public Dog(string name) : base(name)
//             {

//             }
//         }

//         public static void Main(string[] args)
//         {
//             Dog dog=new Dog("Husky");
//         }
//     }
// }


//polymorphism

// namespace Hello
// {
//     public class Example
//     {
//         public class Animal
//         {
//             public virtual void MakeSound()
//             {
//                 Console.WriteLine("Sound");
//             }

//         }

//         public class Dog : Animal
//         {
//             public override void MakeSound()
//             {
//                 Console.WriteLine("Bow");
//             }
//         }

//         public class Cat : Animal
//         {
//             public override void MakeSound()
//             {
//                 Console.WriteLine("Mew");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Animal animal1=new Cat();
//             Animal animal2=new Dog();

//             animal1.MakeSound();
//             animal2.MakeSound();
//         }
//     }
// }



//abstract classes
//an absrat class defines the base concept that cannot be instantiated directly
//we cannot create the object directly of the abstract class but we can create the object of the class inherited from it

//the abstract methods must be implemented in the concrete/inherited class

// using System.ComponentModel.Design.Serialization;

// namespace Hello
// {
//     public class Example
//     {
//         public abstract class Animal
//         {
//             public string? Name{get;set;}
//             public abstract void Speak();
//         }

//         class Dog : Animal
//         {
//             public override void Speak()
//             {
//                 Console.WriteLine("Bow");
//             }
//         }

//          class Cat : Animal
//         {
//             public override void Speak()
//             {
//                 Console.WriteLine("Mew");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Dog dog=new Dog();
//             dog.Speak();
//             Cat cat=new Cat();
//             cat.Speak();
//         }
//     }
// }



//interface==interface is basically a contract that says....any class that implements me must provide these capabilities;


// namespace Hello
// {
//     class Program
//     {
//         public interface INotification
//         {
//             void Send();
//         }

//         public class EmailNotification : INotification
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Sending email");
//             }
//         }

//         public class SmsNotification : INotification
//         {
//             public void Send()
//             {
//                 Console.WriteLine("Sending sms");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             EmailNotification emailNotification=new EmailNotification();
//             SmsNotification smsNotification=new SmsNotification();

//             emailNotification.Send();
//             smsNotification.Send();

//         }
//     }
// }




//a class can implement multiple interfaces
//c# doesnt allow the normal multiple inheritence so we can just use the multiple interfaces


// namespace Hello
// {
//     public class Example
//     {
//         public interface Eating
//         {
//             void Eat();
//         }

//         public interface Walking
//         {
//             void Walk();
//         }

//         public class Human: Eating, Walking
//         {
//             public void Eat()
//             {
//                 Console.WriteLine("Human can eat");
//             }

//             public void Walk()
//             {
//                 Console.WriteLine("Human can walk");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Human human=new Human();
//             human.Walk();
//             human.Eat();
//         }
//     }
// }




//composition vs interface

//composition shows has-a relationship
//composition can be used where interface cannot be...i.e RestaurantService has RestaurantRepository instead of is-a
//restaurantService has dependency in the restaurantRepository



// namespace Hello
// {
//     public class Example
//     {
//         class Engine
//         {
//             public void Start()
//             {
//                 Console.WriteLine("Engine started");
//             }
//         }

//         class Car
//         {
//             private readonly Engine _engine;

//             public Car()
//             {
//                 _engine=new Engine();
//             }

//             public void start()
//             {
//                 _engine.Start();
//             }
//         }
//         public static void Main(string[] args)
//         {
//             Car car=new Car();
//             car.start();
//         }

//     }
// }


//sealed keyword prevents inheritence




//Liskov substituition principle

// If Dog is animal then the code expecting the animal must work with Dog without breaking the expected behaviour...i.e child can substitute the parent

// 

// namespace Hello
// {
//     public class Hello
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
//             public override void Speak()
//             {
//                 Console.WriteLine("Bow");
//             }

        
//         }

//         public static void Main(string[] args)
//         {
//             Animal animal=new Animal();
//             Dog dog=new Dog();

//             void MakeAnimalSpeak(Animal animal)
//             {
//                 animal.Speak();
//             }

//             MakeAnimalSpeak(dog);

//         }
//     }
// }