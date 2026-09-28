
//Generics

// namespace Hello
// {
//     public class Example
//     {
//         public class Box<T>
//         {
//             public T Value{get;set;}
//             public Box(T value)
//             {
//                 Value=value;
//                 Console.WriteLine(Value);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Box<int> intBox=new(10);
//             Box<string> stringBox=new("Hello");
//         }
//     }
// }


//Collections===an object that can hold many values


//List

// using System.Security.Cryptography.X509Certificates;

// namespace Hello
// {
//     public class Example
//     {
//         public static void Main(string[] args)
//         {
            //list

            // List<string> names = new()
            // {
            //     "Ram",
            //     "Hari",
            //     "Sita"
            // };

            // foreach(string name in names)
            // {
            //     Console.WriteLine(name);
            // }


            //Array

            // int[] rolls={1,2,3,4,5};

            // foreach(int roll in rolls)
            // {
            //     Console.WriteLine(roll);
            // }


            // string[] names =
            // {
            //     "Ram",
            //     "Hari",
            //     "Sita"
            // };
            
            // names.Append("Gita");
            // foreach(string name in names)
            // {
            //     Console.WriteLine(name);
            // }



            //Dictionary==dictionary must have unique index, dont allow duplicates index

            // Dictionary<int,string> students = new()
            // {
            //     [1]="Ram",
            //     [2]="Hari",
            //     [3]="Sita",
            //     [4]="Gita"
            // };
            
            // Console.WriteLine(students[2]);

            // foreach(var stud in students)
            // {
            //     Console.WriteLine(stud.Key);
            //     Console.WriteLine(stud.Value);
            // }

            
            //HashSet
            // HashSet<string> students =new()
            // {
            //     "Ram",
            //     "Hari",
            //     "Ram"
            // };
            
            // students.Add("Sita");
            // students.Add("Sita");

            // foreach(string st in students)
            // {
            //     Console.WriteLine(st);
            // }



            //Queue=fifo

            // Queue<int> rolls=new();
            // rolls.Enqueue(2);
            // rolls.Enqueue(3);
            // rolls.Enqueue(3);
            // Console.WriteLine(rolls.Dequeue());
            // foreach(int roll in rolls)
            // {
            //     Console.WriteLine(roll);
            // }



            //stack ,lifo

            // Stack<int> rolls=new();
            // rolls.Push(4);
            // rolls.Push(3);
            // rolls.Push(3);

            // Console.WriteLine($"poped element is{rolls.Pop()}");
            
            // foreach(int rol in rolls)
            // {
            //     Console.WriteLine(rol);
            // }


            //linkedList

            // LinkedList<int> numbers=new();

            // numbers.AddLast(20);
            // numbers.AddLast(30);
            // numbers.AddLast(40);

            // var node=numbers.Find(30);
            // Console.WriteLine(node);

            // foreach(int num in numbers)
            // {
            //     Console.WriteLine(num);
            // }
            
//         }
//     }
// }