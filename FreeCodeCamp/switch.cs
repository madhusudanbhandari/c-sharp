

// var fruit="Mango";

// switch (fruit)
// {
//     case "Apple":
//         Console.WriteLine("your fruit is {fruit}");
//         break;
    
//     case "banana":
//         Console.WriteLine($"Your fruit is{fruit}");
//         break;

//     case "Mango":
//         Console.WriteLine($"Your fruit is {fruit}");    
//         break;

//      default:
//         Console.WriteLine("None of cases match");
//         break;
// }


// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
    
//     case 200:
//     case 100:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");



// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");





//same example using the switch case

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type="Sweat shirt";
        break;

    case "02":
        type="T-shirt";
        break;

    default:
        Console.WriteLine("Didnt match");
        break;
}

switch (product[1])
{
    case "Bl":
        color="Black";
        break;

    case "MN":
        color="Moroon";
        break;

    default:
        color="None";
        break;
}

switch (product[2])
{
   case "L":
    size="Large";
    break;

    case "M":
        size="Medium";
        break;

    default:
        size="small";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
