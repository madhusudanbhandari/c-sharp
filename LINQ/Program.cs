//Linq cases

var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Ram", Salary = 45000, Department = "IT", Age = 24 },
    new Employee { Id = 2, Name = "Sita", Salary = 65000, Department = "HR", Age = 29 },
    new Employee { Id = 3, Name = "Hari", Salary = 75000, Department = "IT", Age = 32 },
    new Employee { Id = 4, Name = "Gita", Salary = 55000, Department = "Finance", Age = 27 },
    new Employee { Id = 5, Name = "Shyam", Salary = 90000, Department = "IT", Age = 35 },
    new Employee { Id = 6, Name = "Rita", Salary = 48000, Department = "HR", Age = 23 },
    new Employee { Id = 7, Name = "Bikash", Salary = 70000, Department = "Finance", Age = 31 },
    new Employee { Id = 8, Name = "Anita", Salary = 85000, Department = "HR", Age = 34 }
};

//1.Where

// var results=employees.
//         Where(e=>e.Salary>60000)
//         .Where(e=>e.Department=="IT");

// foreach(var result in results)
// {
//     Console.WriteLine(result.Name);
// }


// foreach(var employee in employees)
// {
//     Console.WriteLine(employee.Name);
// }

// foreach(var emp in employees)
// {
//     Console.WriteLine($"{emp.Name}\t\t {emp.Salary}");
//     }


//2.Sorting

// var employees1=employees.
//         OrderBy(e=>e.Salary);

// foreach(var emp in employees1)
// {
//     Console.WriteLine(emp.Name);

// }

// var sorted=employees.OrderByDescending(e=>e.Salary);

// foreach(var s in sorted)
// {
//     Console.WriteLine(s.Name);
// }



//3.nested sorting

// var result=employees.
//             OrderBy(e=>e.Department)
//             .ThenByDescending(e=>e.Salary);

// foreach(var r in result)
// {
//     Console.WriteLine($"{r.Department}-{r.Name}-{r.Salary}");
// }


//4.First and FirstOrDefaultAsync()

// var result=employees
//             .Where(e=>e.Salary>80000)
//             .Select(e=>e.Name)
//             .First();

        

// Console.WriteLine(result);


//5.Any=returns boolean


// var result=employees.
//             Any(e=>e.Department=="Teaching");


// Console.WriteLine(result);
            

//6.Count


// var result=employees.
//             Where(e=>e.Department=="HR")
//             .Count();

// Console.WriteLine(result);


//7/Average

// var avg=employees.Average(e=>e.Salary);

// Console.WriteLine(avg);


//8.Max

// var maxSalary=employees.Max(e=>e.Salary);
// Console.WriteLine(maxSalary);

//9.GroupBy

var result=employees.
            GroupBy(e=>e.Department);

foreach(var departments in result)
{
    Console.WriteLine($"Departments-{departments.Key}");

    foreach(var name in departments)
    {
        Console.WriteLine(name.Name);
    }
}


public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public string Department { get; set; } = string.Empty;
    public int Age { get; set; }
}


