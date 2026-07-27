// using System;

// namespace hello
// {
//     class Program
//     {
//         class Car
//         {
//             // string color="red";
//             // string model="new";

//             string color;
//             string model;

//             public void Move()
//             {
//                 Console.Write("My car is movig");
//             }
        
//         static void Main(string[] args)
//         {
//             Car obj=new Car();
//             Car obj2=new Car();
//             obj.color="Red";
//             obj2.model="Latest";
//             Console.WriteLine(obj2.model);
//             Console.WriteLine(obj.color);
//             obj.Move();
//         }
//         }
//     }
// }

///Methods inside class

// using System;

// namespace Hello
// {
//     class Program
//     {
//         class Car
//         {
//             string color="Red";

//             public void Move()
//             {
//                 Console.WriteLine("Car is moving");
//             }
        
//         static void Main(string [] args)
//         {
//             Car obj=new Car();
//             Console.WriteLine(obj.color);
//             obj.Move();

//         }
//         }
//     }
// }





//Constructors

// using System;

// namespace hello
// {
//     class Program
//     {
//         class Car
//         {
//             public string model;

//             public Car(string model)
//             {
//                 this.model=model;
//             }

//             static void Main(string[] args)
//             {
                
//                 Car obj=new Car("Ford");

//                 Console.WriteLine(obj.model);
//             }
//         }
//     }
// }





////Properties=used to access the private variables


// using System;
// using System.Reflection.Metadata;

// namespace hello
// {
//     class Person
//     {
//         private string name="";

    

//         public string Name
//         {
//             get{ return name;}
//             set{name=value;}
            
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person obj=new Person();
//             obj.Name="Madhusudan";
//             Console.WriteLine(obj.Name);

//         }
//     }
// }




// using System;

// namespace hello
// {
//     class Person
//     {
//         private string name="";


//         public string Name
//         {
//             get{return name;}
//             set{name=value;}
//         }

//         static void Main(string [] args)
//         {
//             Person obj=new Person();
//             obj.Name="Karan";
//             Console.WriteLine(obj.Name);
//         }
//     }
// }



//automatic properties

// using System;

// namespace hello
// {
//     class Person
//     {
//         public string Name
//         {
//             get; set;
//         }

//         class Program
//         {
//             static void Main(string[] args)
//             {
//                 Person obj=new Person();
//                 obj.Name="Sompal";
//                 Console.WriteLine(obj.Name);
//             }
//         }
//     }
//}






