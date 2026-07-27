// //enums=special class with the group of constants that are read only

// // using System;

// // namespace hello
// // {
// //     class Program
// //     {
// //         enum Level
// //         {
// //             High,
// //             Medium,
// //             Low
// //         }
// //         static void Main(string[] args)
// //         {
// //             Level mylevel=Level.High;
// //             Level mylevel2=Level.Low;
// //             Console.WriteLine((int)mylevel);
// //             Console.WriteLine((int)mylevel2);
// //         }
// //     }
// // }


// //assigning values

// using System;

// namespace hello
// {
//     class Program
//     {
//         enum Months
//         {
//             Jan,
//             Feb,
//             Mar=5,

//             Apr
//         }

//         static void Main(string[] args)
//         {
//             Months mymonth=Months.Apr;
//             Console.WriteLine((int)mymonth);
//         }
//     }
// }



//C# files


// using System.IO;

// string writeText="Hello World";
// File.WriteAllText("filename.txt",writeText);


// string readText=File.ReadAllText("filename.txt");
// Console.WriteLine(readText);


// using System.IO;

// string myText="How u doing";
// File.WriteAllText("new.txt",myText);


// string newText="This is my new text";
// File.AppendAllText("new.txt",newText);

// string read=File.ReadAllText("new.txt");
// Console.WriteLine(read);






///C# exceptions

//try and catch block


// try
// {
//     int[] nums={1,2,3,4};
//     Console.WriteLine(nums[10]);
// }catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }



// try
// {
//     int[] nums={1,2,4,5};
//     Console.WriteLine(nums[34]);
// }
// catch(Exception e)
// {
//     Console.WriteLine("Something went wrong");
// }
// finally
// {
//     Console.WriteLine("Finished the try catch block");
// }



//thorw message


    // int age=43;
    // if (age < 18)
    // {
    //     throw new ArithmeticException("Access denied age less than 18");
    // }
    // else
    // {
    //     Console.WriteLine("Allowed");
    // }

