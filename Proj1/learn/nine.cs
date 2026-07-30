// using System;

// namespace hello
// {
//     class Program
//     {
//         static void Main(String[] args)
//         {
//             int [] nums={1,2,3,4,5};

//             var evenNumbers=from num in nums
//                             where num%2==0
//                             select num;

//             Console.WriteLine("Even numbers");


//             foreach(int evnum in evenNumbers)
//             {
//                 Console.WriteLine(evnum);
//             }

            
//         }
//     }
// }








// using System;
// using System.Security.Cryptography;

// namespace hello
// {
//     class Student
//     {
//         public string Name{get; set;}
//         public int Marks{get; set;}

//     }

//     class Program
//     {
//         static void Main()
//         {
//             List<Student> students=new List<Student>
//             {
//                 new Student {Name="Madhu", Marks=22},
//                 new Student {Name="Kapil",Marks=34},
//                 new Student {Name="Hari",Marks=23},
//             };


//             var topstudent=students.Where(stud=>stud.Marks<30);

//             foreach(var mark in topstudent)
//             {
//                 Console.WriteLine($"{mark.Name}-{mark.Marks}");
                
//             }
//         }
        
//     }
// }





//Delegates==variable that stores the method

// using  System;
// namespace hi
// {
//     delegate void Message();

//     class Program
//     {
//         static void hello()
//         {
//             Console.WriteLine("Hello sir");
//         }

//         static void Main()
//         {
//             Message msg=hello;
//             msg();
//         }
//     }
// }




//Lambda Expression


// using System;

// namespace hello
// {
//     delegate void Message();

//     class Student
//        {
//         public string Name{get; set;}
//         public int Age{get; set;}
//     }

//     class Program
//     {
//         static void Main(){

//         List<Student>students=new List<Student>
//         {
//             new Student{ Name="Ram",Age=34},
//             new Student{Name="Kapil",Age=24},
//             new Student{Name="Hari",Age=4}
//         };

//         var mystud = students.Where(s => s.Age < 30);

//         foreach(var stud in mystud)
//             {
//                 Console.WriteLine($"{stud.Name}-{stud.Age}");
//             }
//         } 
//     }
// }




//Generic 


// using System;

// namespace  Name
// {
//     class Box<T>
//     {
        
//         public T Value {get; set;}
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Box<int> intBox=new Box<int>();
//             intBox.Value=23;


//             Box<string> stringBox=new Box<string>();
//             {
//                 stringBox.Value="Helllo";
//             }

//             Console.WriteLine(intBox.Value);
//             Console.WriteLine(stringBox.Value);
//         }
//     }
    
// }


