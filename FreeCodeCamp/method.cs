
// //methods

// // void sayHello()
// // {
// //     Console.WriteLine("Hello");
// // }

// // sayHello();


// // string sayHello()
// // {
// //     return "Hello";
// // }

// // Console.WriteLine(sayHello());



// void randomNums()
// {  
//     Random random=new Random();
//      int nums=0;


//     do{
//      nums=random.Next(1,10);
//     Console.WriteLine(nums);

//     }while(nums!=5);
// }

// randomNums();



//parameters

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


//value and reference type parameters

//pass by value

// int a=5;
// int b=6;

// void Add(int a, int b)
// {
//     int sum=a+b;
//     Console.WriteLine($"sum:{sum}");

// }

// Add(5,6);
// Console.WriteLine($"The sum is: {a}+{b}");


//pass by reference

// using System.Runtime.InteropServices;

// int[] array={1,2,3,4,5};

// void PrintArray(int[] array)
// {
//     foreach(int a in array)
//     {
//         Console.WriteLine(a);
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for(int i=0;i<array.Length; i++)
//     {
//         array[i]=0;
//     }
// }

// PrintArray(array);
// Clear(array);
// PrintArray(array);



//named and optional parameters

string[] guestList={"Hari","Sita","Gita","Rita"};
string[] rsvps=new string[10];
int count=0;

void RSVP(string name, int partySize, string allergies,bool inviteOnly)
{
    if (inviteOnly)
{
    bool found = false;
    foreach (string guest in guestList)
    {
        if (guest.Equals(name)) {
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Sorry, {name} is not on the guest list");
        return;
    }
}
    rsvps[count]=$"Name:{name}, \tParty Size:{partySize}, \tAllergies:{allergies}";
    count++;

}

void ShowRSVPs()
{
    Console.WriteLine("\n Total RSVPs:");
    for(int i=0; i<count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}