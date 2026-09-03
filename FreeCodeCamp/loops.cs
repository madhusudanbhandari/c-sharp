//For loop

// for(int i=0; i<10; i++)
// {
//     if(i==5) continue;

//     Console.WriteLine(i);

// }

// string[] names=["Ram","Hari","Sita","Gia"];


// for(int i = names.Length - 1; i >= 0; i--)
// {

//     if(names[i]=="Ram") 
//         names[i]="Kabir";

//     Console.WriteLine(names[i]);

// }


// foreach(string name in names)
// {
//     if(name=="Ram") 
//         name="Kabir";
// }




//challenge

// for(int i = 0; i <= 100; i++)
// {
//     if(i%3==0 && i%5 == 0)
//     {
//         Console.WriteLine($"{i} FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} Buzz");
//     }

//     else
//     {
//         Console.WriteLine(i);
//     }
// }



//Do-While looop

// int i=0;

// do
// {
//     Console.WriteLine(i);
//     i++;
// }
// while(i<5);


// Random value=new Random();

// int currentValue=0;

// do
// {
//     currentValue=value.Next(1,10);
//     Console.WriteLine(currentValue);
// }
// while(currentValue!=7);


//while

// int i=0;
// while (i < 5)
// {
//     Console.WriteLine(i);
//     i++;
// }





//game challenge

// int hero=10;
// int monster=10;

// Random dice=new Random();

// do
// {
//     int roll=dice.Next(1,11);

//     monster-=roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if(monster<=0) continue;

//     roll=dice.Next(1,11);
//     hero-=roll;
//     Console.WriteLine($"Hero was damaged and lost{roll} health and now has {hero} health");


// }while(hero>0 && monster>0);

// Console.WriteLine(hero>monster ? "Hero wins":"monster wins");


// string? readLine;
// Console.WriteLine("Enter a string:");
// do
// {
//     readLine=Console.ReadLine();
// }while(readLine==null);


// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);


//project 1

// int input=0;
// Console.WriteLine("Enter the number between 5 and 10");

// do
// {
//     string? inputTaken=Console.ReadLine();
//     int.TryParse(inputTaken,out input);

//     if(input<5 || input > 10)
//     {
//         Console.WriteLine("Enter a number between 5 and 10");

//     }
// }while(input<5 || input>10);
// Console.WriteLine(input);



//project2

// Console.WriteLine("Enter role:");
// string? inputTaken="";
// do
// {
//      inputTaken=Console.ReadLine()!;

   
//     if(inputTaken.ToLower().Trim()!="Admin"&& inputTaken.ToLower().Trim()!="Manager" && inputTaken.ToLower().Trim() != "User")
//     {
//         Console.WriteLine("Please enter a valid role");
//     }

//  } while(inputTaken.ToLower().Trim()!="admin"&& inputTaken.ToLower().Trim()!="manager" && inputTaken.ToLower().Trim() != "user");



//project2

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();



//project3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {

        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}