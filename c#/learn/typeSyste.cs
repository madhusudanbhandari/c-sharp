//Type system:

//class vs struct

// namespace Hello
// {
//     public class Hello
//     {
//         //class
//     //    public class Student
//     //     {
//     //         public string? Name{get;set;}
//     //     } 

//     //     public static void Main(string[] args)
//     //     {
//     //         Student s1=new Student();
//     //         s1.Name="Ram";

//     //         Student s2=s1;
//     //         s2.Name="Hari";

//     //         Console.WriteLine(s1.Name);
//     //         Console.WriteLine(s2.Name);
//     //     }


//         //struct==struct can have the methods and the constructors

//         // struct Point
//         // {
//         //     public int x;
//         //     public int y;
//         // }

//         // public static void Main(string[] args)
//         // {
//         //     Point p1=new Point();
//         //     p1.x=10;
//         //     p1.y=20;


//         //     Point p2=p1;
//         //     p2.x=9;

//         //     Console.WriteLine(p1.x);
//         //     Console.WriteLine(p2.x);

//         // }

//     }
// }



//enum==enum represents the fixed set up named values with the default values starting from 0 that can be set explicitly too


//record vs class

// namespace Hello
// {
//     class Example
//     {    

//         //class==doesnot use the value-based equality. they use the reference based equality

//         // class Student
//         // {
//         //     public string? Name{get;set;}
//         //     public int Age{get;set;}

//         //     public Student(string name,int age)
//         //     {
//         //         Name=name;
//         //         Age=age;
//         //     }
//         // }

//         // public static void Main(string[] args)
//         // {
//         //     Student s1=new Student("Madhu",22);
//         //     Student s2=new Student("Madhu",22);

//         //     Console.WriteLine(s1.Name);
//         //     Console.WriteLine(s1==s2);
//         // }



//         //record uses the value based equality by default
//             // records are designed  for the immutability
//             // i.e cant modify like  person.age=30;
//             // instead we can do......do non-destructive mutation
//             // i.e Person updated=person with{
//             //    Age=30
//             // }


//         // public record Person(string Name,int Age);

//         // public static void Main(string[] args)
//         // {
//         //     Person p1=new Person("Madhu",22);
//         //     Console.WriteLine(p1.Name);
//         //     Person p2=new Person("Madhu",22);   
//         //     Console.WriteLine(p1==p2);

//         //     //p2.Age=30;  cant do this
//         //     Person updated=p2 with
//         //     {
//         //         Age=30
//         //     };
//         //     Console.WriteLine(p2.Age);

//         // }

//     }
// }




//record struct,   record=value-based equality ,struct==value type


// namespace Hello
// {
//     class Example
//     {
//         public record struct Point(int x, int y);
//          public static void Main(string[] args)
//         {
//             Point point=new Point(3,4);
//             Point p2=new Point(3,4);
//             Console.WriteLine(point==p2);
//         }

//     }
// }



//Equality and hashing
//== vs ReferenceEquals

// namespace Hello
// {
//     class Example
//     {
//         public class Person
//         {
//             public string? Name{get;set;}

//             public Person(string name)
//             {
//                 Name=name;
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Person p1=new Person("Ram");
//             Person p3=p1;

//             Console.WriteLine(p1==p3);
//             Console.WriteLine(ReferenceEquals(p1,p3));
//         }
//     }
// }



