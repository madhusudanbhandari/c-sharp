// //inheritence

// using System;

// namespace Hello
// {
//     class College
//     {
//         public string name="Ncit";
//         public void Branches()
//         {
//             Console.WriteLine("there are 10 branches");
//         }

//     }
//     class Software : College
//     {
//         public string result="Good";
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Software soft=new Software();
//             soft.Branches();
//             Console.WriteLine(soft.name);
//             Console.WriteLine(soft.result);
//         }
//     }
// }




//Polymorphism


// using System;

// namespace hello
// {
//     class Animal
//     {
//         public virtual void MakeSound()
//         {
//             Console.WriteLine("Animal makes sound");
//         }
//     }
//     class Dog : Animal
//     {
//         public override void MakeSound()
//         {
//             Console.WriteLine("Bark Bark");
//         }
//     }

//     class Cat : Animal
//     {
//         public override void MakeSound()
//         {
//             Console.WriteLine("Mew Mew");
//         }
//     }


//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Animal an=new Animal();
//             Cat catobj=new Cat();
//             Dog dogobj=new Dog();

//             an.MakeSound();
//             dogobj.MakeSound();
//             catobj.MakeSound();
//         }
//     }
// }


//Abstraction


// using System;
// using System.Security.Cryptography;
// namespace hello
// {
//     class Car
//     {
//         public void Start()
//         {
//             CheckFuel();
//             StartEngine();
//             CheckBattery();

//             Console.WriteLine("Car Started");

//         }

//         private void CheckFuel()
//         {
//             Console.WriteLine("Fuel checked");
//         }

//         private void StartEngine()
//         {
//             Console.WriteLine("Engine Started");
//         }

//         private void CheckBattery()
//         {
//             Console.WriteLine("Battery checked");
//         }

        

//     }

//     class Program
//     {
//         static void Main(string [] args)
//         {
//             Car car1=new Car();
//             car1.Start();
//         }
//     }
// }



// using System;

// namespace hello
// {
//    abstract class Animal
//     {
//         public abstract void makeSound();

//         public void sleep()
//         {
//             Console.WriteLine("zzzz");
//         }
//     }

//     class Dog: Animal
//     {
//         public override void makeSound()
//         {
//             Console.WriteLine("Bark");
//         }
//     }

//     class Program
//     {
//         static void Main(string [] args)
//         {
//             Dog newDog=new Dog();
//             newDog.makeSound();
//             newDog.sleep();
//         }
//     }
// }



//Iterface dor abstraction

// using System;

// namespace hello
// {
//     interface IAnimal
//     {
//         void animalSound();
//     }
//     class Dog : IAnimal
//     {
//         public void animalSound()
//         {
//             Console.WriteLine("Animal makes sound");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] argrs)
//         {
//             Dog doges=new Dog();
//             doges.animalSound();
//         }
//     }
// }


//Multiple inheritence

// using System;

// namespace hello
// {
//     interface IFirst
//     {
//         void myMethod();
//     }
//     interface ISecond
//     {
//         void myOtherMethod();
//     }

//     class Demo : IFirst, ISecond
//     {
//         public void myMethod()
//         {
//             Console.WriteLine("This is my first method");
//         }

//         public void myOtherMethod()
//         {
//             Console.WriteLine("This is my other methodo");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Demo demo=new Demo();
//             demo.myMethod();
//             demo.myOtherMethod();
//         }
//     }
// }



