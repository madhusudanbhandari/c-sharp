using System;

namespace three
{
    class Program
    {

        static float Avg(int a,int b, int c)
        {
            float avg=(a+b+c)/3F;
            return avg;
        }
        static void Main(string[] args)
        {

            //1.if else== conditional satements
            // int age=18;
            // if (age > 18)
            // {
            //     Console.WriteLine("You can drive");
            // }
            // else if (age ==18)
            // {
            //     Console.WriteLine("You can drive");
            // }
            // else
            // {
            //     Console.WriteLine("You cannot drive");
            // }




            //Switch case

            // int age=6;
            // switch (age)
            // {
            //     case 18:
            //      Console.WriteLine("Hello you are 18");
            //      break;

            //     case 34:
            //      Console.WriteLine("You are 34");
            //      break;

            //      default:
            //       Console.WriteLine($"Hello you are {age}");
            //       break;
            // }


            //Loops in c#

            // int i=1;
            // while (i < 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            
            // for(int i=0;i<=5;i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int i=5;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }while(i<14);

            

            //break and continue

            // for(int i=0;i<5;i++)
            // {
            //     // Console.WriteLine(i);
            //     // break;

            //     if (i == 3)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }



            //Functions/Methods

            float avg=Avg(2,5,7);
            Console.WriteLine(avg);




        }
    }
}