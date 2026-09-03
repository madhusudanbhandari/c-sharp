

// class Fruit
// {
//     string color="red";
//     string Name="Apple";

//     public static void Main(string[] args)
//     {
//         Fruit f1=new Fruit();
//         Fruit f2=new Fruit();

//         Console.WriteLine($" Name of my first fruit is{f1.Name} and its color is {f1.color} ");
//         Console.WriteLine($" Name of my second fruit is{f2.Name} and its color is {f2.color} ");


//     }
// }



// using System.Drawing;

// class Car
// {
//     public string color="Red";
//     public string model="2026";

//     public  void engineStart()
//     {
//         Console.WriteLine("Engine has started");
//     }


// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Car car=new Car();

//         Console.WriteLine($" Color of my car is { car.color} and model { car.model}");

//         car.engineStart();

//         Console.WriteLine(args[0]);
//     }
// }


//using costructor

// class Car
// {
//     public string Color;
//     public string Model;

//     public Car(string assignedColor, string assignedModel)
//     {
//         Color=assignedColor;
//         Model=assignedModel;
//     }

//     static void Main(string[] args)
//     {
//         Car Ford=new Car("Red","2026");
//         Console.WriteLine($"Car has color {Ford.Color} and model {Ford.Model}");

//     }
// }



//method overloading

// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a+b;

//     }

//     public int Add(int a, int b, int c)
//     {
//         return a+b+c;
//     }

//     public double Add(double a, double b)
//     {
//         return a+b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Calculator calc=new Calculator();

//         Console.WriteLine(calc.Add(1,2));
//         Console.WriteLine(calc.Add(5,67,2));
//         Console.WriteLine(calc.Add(34.2,56.4));
//     }
// }


//constructor overloading

// class Car
// {
//     public string Name;
//     public string Model;
//     public int Year;

//     public Car()
//     {
//         Name="unknown";
//         Model="unknown";
//         Year=0;
//     }

//     public Car(string assignedName)
//     {
//         this.Name=assignedName;
//         Model="unknown";
//         Year=0;
//     }

//     public Car(string assignedName, string assignedModel)
//     {
//         this.Name=assignedName;
//         this.Model=assignedModel;
//         Year=0;
//     }
//     public Car(string assignedName, string assignedModel,int assignedYear)
//     {
//         this.Name=assignedName;
//         this.Model=assignedModel;
//         this.Year=assignedYear;
//     }


// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car1=new Car();
//         Car car2=new Car("Ferrari");
//         Car car3=new Car("Suzuki","Not so new");
//         Car car4=new Car("BYD","Newest",2025);

//         Console.WriteLine($" Name of car is {car1.Name}, with model {car1.Model}, and made in year {car1.Year}");
//         Console.WriteLine($" Name of car is {car2.Name}, with model {car2.Model}, and made in year {car2.Year}");
//         Console.WriteLine($" Name of car is {car3.Name}, with model {car3.Model}, and made in year {car3.Year}");
//         Console.WriteLine($" Name of car is {car4.Name}, with model {car4.Model}, and made in year {car4.Year}");

//     }
// }


///access modifiers

// class Car
// {
//     private string model="Mustang";

//     static void Main(string[] args)
//     {
//         Car car=new Car();

//         Console.WriteLine(car.model);
//     }
// }



//Properties==are basically used to access and update the private fields using the variable and methods ,it has methods like get;set;

// class Person
// {
//     private string name="";

//     public string Name
//     {
//         get{ return name;}
//         set{name=value;}
//     }  
// }

// class Program
// {
//     static void Main()
//     {
//         Person person=new Person();
//         person.Name="Ram";
//         Console.WriteLine(person.Name);
//     }
// }


//shorthand properties

// class Person
// {
//     public string Name{get;set;}
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person myObj=new Person();

//         myObj.Name="Madhu";
//         Console.WriteLine(myObj.Name);
//     }
// }



//inheritence

//  class Vehicle
// {
//     public string brand="Ford";
//     public void Honk()
//     {
//         Console.WriteLine("Blowing horn");
//     }
// }

// class Car : Vehicle
// {
//     public string modelName="Mustang";
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Car myCar=new Car();

//         myCar.Honk();
//         Console.WriteLine(myCar.brand+" "+myCar.modelName);
//     }    
// }


//polymorphism

// class Animal
// {
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Animal makes a sound");
//     }
// }

// class Pig : Animal
// {
//      public override void MakeSound()
//     {
//         Console.WriteLine("Pigs sound");
//     }
// }

// class Dog: Animal
// {
//      public override void MakeSound()
//     {
//         Console.WriteLine("Bow Bow");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal animalObj=new Animal();
//         Pig pigObj=new Pig();
//         Dog dogObj=new Dog(); 


//         animalObj.MakeSound();
//         pigObj.MakeSound();
//         dogObj.MakeSound();
//     }

// }



//abstration


// abstract class Animal
// {
//     public abstract void animalSound();

//     public void sleep()
//     {
//         Console.WriteLine("zzzz");
//     }
// }

// class Dog : Animal
// {
//     public override void animalSound()
//     {
//        Console.WriteLine("we we"); 
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog dog=new Dog();
//         dog.animalSound();
//         dog.sleep();
//     }
// }


//Interfaces

// interface IAnimal
// {
//     void makeSound();
// }

// class Pig : IAnimal
// {
//     public void makeSound()
//     {
//         Console.WriteLine("The pig says:we we");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Pig myPig=new Pig();
//         myPig.makeSound();
//     }
// }



//multiple interfaces

// interface IOneInterface
// {
//     public void firstMethod()
//     {

//     }
// }

// interface ISecondInterface
// {
//     public void secondMethod()
//     {

//     }
// }

// class MyClass: IOneInterface, ISecondInterface
// {
//     public void firstMethod()
//     {
//         Console.WriteLine("This is my first Method");
//     }

//     public void secondMethod()
//     {
//         Console.WriteLine("This is my second method");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         MyClass myClass=new MyClass();
//         myClass.firstMethod();
//         myClass.secondMethod();
//     }
// }


//Enums

// enum Levels
// {
//     Low,
//     High,
//     Medium
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Levels level=Levels.Medium;
//         Console.WriteLine(level);
//         Console.WriteLine(((int)level));
//     }
// }


///Files
using System.IO;

// var newFile=File.Create("File1.txt");

// File.WriteAllText("File1.txt","Helllo guys");
Console.WriteLine(File.ReadAllText("File1.txt"));