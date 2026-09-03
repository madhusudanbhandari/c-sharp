// Random random = new Random();
// int daysUntilExpiration = random.Next(120);

// Console.WriteLine(daysUntilExpiration);

// if (daysUntilExpiration <= 10)
// {
    
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
//      if (daysUntilExpiration <= 5)
//     {
//         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//         Console.WriteLine("Renew now and save 10%!");
//     }else if (daysUntilExpiration == 1)
//     {
//         Console.WriteLine("Your subscription expires within a day! \n Renew now and save 20%!");
//     }else if (daysUntilExpiration <= 0)
//     {
//         Console.WriteLine("expired");
//     }
// }
// else 
// {
//     Console.WriteLine("nothing");
// }


//arrays

// string [] studentIds=new string[4];
// studentIds[0]="ab1";
// studentIds[1]="ab2";
// studentIds[2]="ab3";
// studentIds[3]="ab4";

// foreach(string id in studentIds)
// {
//     Console.WriteLine(id);
// }

// studentIds[3]="ab5";

// foreach(string id in studentIds)
// {
//     Console.WriteLine(id);
// }

// int[] studentIds=[10,20,30,40,50];
// int sum=0;
// int index=0;
// foreach(int id in studentIds)
// {
//     sum+=id;
//     index++;
//     Console.WriteLine($"The value of index {index} is {id}");
// }
//     Console.WriteLine($"Sum is {sum}");



//Code Challenge

// string[] fraudIds={"B123","C234","A345","C15","B177","G3003","C235","B179"};

// foreach(string id in fraudIds)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine($"{id} is a fraud Id");
//     }
// }




// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");



string str="The quick brown fox jumps over the lazy dog";

char[] charMessage=str.ToCharArray();
Array.Reverse(charMessage);

int x=0;
foreach(char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message=new string(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times");