//delegate
//delegate is the type used to represent the methods


// namespace Hello
// {
//     public class Example
//     {
//         public delegate int Calculator(int a,int b);

//         public static int Add(int a ,int b)
//         {
//             return a+b;
//         }

//         public static void Main(string[] args)
//         {
//             Calculator calc=Add;
//             int result=calc(3,4);

//             Console.WriteLine(result);
//         }
//     }

// }




///exception

// namespace Hello
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {

//             int x=12;
//             int y=2;

//             try
//             {
//                  int result=x/y;
//                 Console.WriteLine(result);
//             }
//             catch (DivideByZeroException)
//             {
//                 Console.WriteLine("Cannot divide by zero");
//             }


//         }
//     }
// }


//async await

// namespace Hello
// {
//     public class Example
//     {
//         public static void Main(string[] args)
//         {
//             async Task<int> GetNumbersAsync()
//             {
//                 await Task.Delay(20);
//                 return 40;
//             }

//             Task<int> task=GetNumbersAsync();
//             Console.WriteLine(task);
//         }
//     }
// }
