// using System.Collections.Generic;
// using System.Linq;

// var employees = new List<Employee>
// {
//     new Employee { Id = 1, Name = "Ram", Salary = 45000, DepartmentId = 1, Age = 24 },
//     new Employee { Id = 2, Name = "Sita", Salary = 65000, DepartmentId = 2, Age = 29 },
//     new Employee { Id = 3, Name = "Hari", Salary = 75000, DepartmentId = 1, Age = 32 },
//     new Employee { Id = 4, Name = "Gita", Salary = 55000, DepartmentId = 3, Age = 27 },
//     new Employee { Id = 5, Name = "Shyam", Salary = 90000, DepartmentId = 1, Age = 35 },
//     new Employee { Id = 6, Name = "Rita", Salary = 48000, DepartmentId = 2, Age = 23 },
//     new Employee { Id = 7, Name = "Bikash", Salary = 70000, DepartmentId = 3, Age = 31 },
//     new Employee { Id = 8, Name = "Anita", Salary = 85000, DepartmentId = 2, Age = 34 }
// };


// var departments=new List<Department>
// {
//     new Department{Id=1,Name="IT"},
//     new Department{Id=2,Name="HR"},
//     new Department{Id=3,Name="Finance"}
// };



// var result=employees.Join(
//         departments,
//         e=>e.DepartmentId,
//         d=>d.Id,
//         (e, d) => new
//         {
//             EmployeeName=e.Name,
//             DepartmentName=d.Name,
//         }
//         );

// foreach(var res in result)
// {
//     Console.WriteLine($"{res.EmployeeName}={res.DepartmentName}");
// }

 




// public class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; } = string.Empty;
//     public decimal Salary { get; set; }
//     public int DepartmentId { get; set; }
//     public int Age { get; set; }
// }


// public class Department
// {
//     public int Id{get;set;}
//     public string Name{get;set;}=string.Empty;
// }