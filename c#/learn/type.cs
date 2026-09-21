//value types

// int x=10;
// int y=x;
// Console.WriteLine(x);
// Console.WriteLine(y);



//reference type



// public class Example
// {
//     public class Employee
//     {
//         public string? Name{get;set;}
//     }

//     public static void Main()
//     {
//         Employee e1=new Employee();
//         e1.Name="Ram";
//         Console.WriteLine(e1.Name);
//         Employee e2=e1;
//         e2.Name="Hari";
//         Console.WriteLine(e1.Name);
//     }
// }


//value type with parameters

// using Microsoft.AspNetCore.Components;

// namespace Hello
// {
//     class Example
//     {
//         static void Change(int x)
//         {
//             x=10;
//         }

//         static void Main(string[] args)
//         {
//             int number=100;
//             Change(number);
//             Console.WriteLine(number);
//         }

//     }
// }


//referene type with parameters

// namespace Hello
// {
//     public class Example
//     {
//         public class Employee()
//         {
//             public string Name{get;set;}
//         }
//         static void Change(Employee employee)
//         {
//             employee.Name="Ram";
//         }

//         static void Main(string[] args)
//         {
//             Employee e=new Employee
//             {
//                 Name="Hari"
//             };

//             Change(e);

//             Console.WriteLine(e.Name);
//         }
//     }
// }