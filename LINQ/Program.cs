//Set Operations

//1.Distinct

// var departmentIds=new List<int>
// {
//     1,2,2,1,4,3,1
// };


// var results=departmentIds.Distinct();


// foreach(var result in results)
// {
//     Console.WriteLine($"After distinct {result}");
// }

//2.Union

// var class1=new List<int>
// {
//     1,2,3
// };

// var class2=new List<int>
// {
//     3,4,5,6
// };

// var results=class1.Union(class2);

// foreach(var result in results)
// {
//     Console.WriteLine(result);
// }



//3.Intersect

// var first=new List<int>{1,3,4,5};
// var second=new List<int>{2,4,5,6};

// var result=first.Intersect(second);

// foreach(var r in result)
// {
//     Console.WriteLine(r);
// }


//5.Except

// var first=new List<int>{1,3,4,5};
// var second=new List<int>{2,4,5,6};

// var result=first.Except(second);

// foreach(var r in result)
// {
//     Console.WriteLine(r);
// }

// // int [] numbers=new int[10];

// var numbers=new int[2];
// numbers[0]=1;
// numbers[1]=3;

// foreach(int num in numbers)
// {
//     Console.WriteLine(num);
// }


//list

// List<int> numbers=new List<int>();

var list=new List<int>();

list.Add(4);
list.Add(5);


foreach(int num in list)
{
    Console.WriteLine(num);
}