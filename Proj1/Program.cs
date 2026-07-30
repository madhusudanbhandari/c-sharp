// //events

// using System;

// namespace Name
// {
//     class Button
//     {
//         public event Action? Click;

//         public void Press()
//         {
//             Console.WriteLine("Button Pressed");

//             Click?.Invoke();
//         }

//         class Door
//         {
//             public void Open()
//             {
//                 Console.WriteLine("Door opens");
//             }
//         }

//         class Light
//         {
//             public void TurnOn()
//             {
//                 Console.WriteLine("Light is turned on");
//             }
//         }

//         class Program
//         {
//             static void Main()
//             {
//                 Button btn=new Button();
//                 Door door=new Door();
//                 Light light=new Light();

//                 btn.Click+=door.Open;
//                 btn.Click+=light.TurnOn;
//                 btn.Press();

//             }
//         }

//     }
// }





//Async Await

//example without async await

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Start");

//         Thread.Sleep(5000);

//         Console.WriteLine("Finished");
//     }
// }



//With async

// using System;

// class Program
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Start");

//         await Task.Delay(5000);

//         Console.WriteLine("Finished");
//     }
// }




///Records are used to compare the data


//Without Records
//normal class doesnot compare values/data
// class student
// {
//     public string Name{set; get;}
// }

// class Program
// {
//     static void Main()
//     {
//         student s1=new student{Name="Madhu"};
//         student s2=new student{Name="Madhu"};

//         Console.WriteLine(s1==s2);
//     }
// }



//with record

public record Person(
    string name,
    int age
);

class Program
{
    static void Main()
    {
        Person p1=new Person("Madhu",22);
        Person p2=new Person("Madhu",22);

        Console.WriteLine(p1==p2);
    }
}