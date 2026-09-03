// using LINQ.Data;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.EntityFrameworkCore;
// using System;


// var builder=WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<AppDbContext>(options=>
// options.UseNpgsql(
//     builder.Configuration.GetConnectionString("DefaultConnection")
// ));

// builder.Services.AddControllers();

// var app=builder.Build();

// app.UseHttpsRedirection();
// app.UseAuthentication();
// app.MapControllers();
// app.Run();




//1.basic Linq`
// namespace Example
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             //3 steps of the linq
            
//             //1.Data source
//             int[] nums={20,3,4,12,15,16,11,16};

//             //2.create query

//             //sorting example
//             var num= from i in nums where i>10 orderby i descending select i;

//             //3. Run the query
//             foreach (int i in num)
//             {
//                 Console.WriteLine(i);
//             }




//         }
//     }
//}




