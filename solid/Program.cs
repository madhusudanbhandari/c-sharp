//middlewares and the request pipeline


// var builder=WebApplication.CreateBuilder(args);

// builder.Services.AddControllers();


// var app=builder.Build();

// app.UseMiddleware<RequestLoggingMiddleware>();

// app.MapControllers();

// app.Run();


// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 1: Before");
//     await next();
//     Console.WriteLine("Middleware 2: After");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 2: Before");
//     await next();
//     Console.WriteLine("Middleware 2: After");
// });

// app.Run(async context =>
// {
//     Console.WriteLine("Executed");

//     await context.Response.WriteAsync("Hello");
// });




//ref vs out vs in


//in normal method..it receives the copy of the value hold by variable and it cannnot change the original variable


// namespace Hello
// {
//     class Program
//     {        
//         public static void Main(string[] args)
//         {
//             void changeNumber(int number)
//             {
//                 number=100;
//             }

//             int x=10;

//             changeNumber(x);

//             Console.WriteLine(x);
//         }
//     }
// }



//ref==but ref allows the method to read the variable and change the value of the original variable

// namespace Hello
// {
//     class Program
//     {
//        static void Main(string[] args)
//         {
//             void changeNumber(ref int number)
//             {
//                 number=100;
//             }

//             int x=10 ;

//             changeNumber(ref x);
//             Console.WriteLine(x);
//         }
//     }
// };



//out is basically used to return a value through the parameter

// namespace Hello
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             void getValues(out int x, out int y)
//             {
//                 x=6;
//                 y=7;
//             }

//             getValues(out int a,out int b);
//             Console.WriteLine(a);
//             Console.WriteLine(b);
//         }
//     }
//}



//in==read the original value without modifying it through the parameter
//in makes the variable read only,cannot be modified

// namespace Hello
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             void readNumber(in int x)
//             {
//                 Console.WriteLine(x);
//                 //x=100;  //Cannot assign to variable 'x' or use it as the right hand side of a ref assignment because it is a readonly variable

//             }

//             int x=10;

//             readNumber(x);
    
    
//         }
        
        
//     }
// }