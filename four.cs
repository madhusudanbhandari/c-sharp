using System;

namespace hell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World sathi");
            //Console.WriteLine("This is lline 2");

            // string name="Madhusudan";
            // name="Bhandari";
            // Console.WriteLine(name);

            // int age=22;
            // age=23;
            // Console.WriteLine(age);

            // const int age=23;
            // age=22;
            // Console.WriteLine(age);

            // string firstname="Madhusudan";
            // string lastname="Bhandari";

            // Console.WriteLine("My name is "+firstname+" "+lastname);

            //Multiple variables

            // int a=5,b=6, c=7;
            // int d,e,f;
            // d=e=f=7;
            // Console.WriteLine(a+f+b+c);

        //Type casting
        //implicit type casting

        // int num=22;
        // float mynum=num;
        // Console.WriteLine(mynum);

        //explicit casting

        // double num=22.78;
        // int num1=(int)num;

        // Console.WriteLine(num);
        // Console.WriteLine(num1);    
    
        // Console.Write("Enter your name:");
        // string name=Console.ReadLine();
        // Console.WriteLine(name);

        // Console.WriteLine("Enter your age:");
        // int age=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Your age is"+age);


        //comparision operators

        // int a=5;
        // int b=6;
        // Console.WriteLine(a>b);

        //Logical Operators

        // int a=5;
        // int b=7;
        // int c=2;

        // Console.WriteLine(a<b || a<c);

        //Math function in c#

        // Console.WriteLine(Math.Max(3,6));
        // Console.WriteLine(Math.Abs(-3.5));

        //Strings in c#


        // string name="Madhusudan";
        // string lname="Bhandari";
        // // Console.WriteLine(name.Length);
        // // Console.WriteLine(name.ToUpper());
        // // Console.WriteLine(string.Concat(name+lname));

        // Console.WriteLine($"My name is : {name} {lname}");

        //Accessing Strings

        // string myName=" is Madhusudan";
        // Console.WriteLine(myName[3]);
        // Console.WriteLine(myName.IndexOf("M"));

        // Console.WriteLine($"My name \n Madhusudan  \"Bhandari\" ho");

        // }


        // int age=18;
        //     if (age > 18)
        //     {
        //         Console.WriteLine("You can vote");
        //     }else if (age == 18)
        //     {
        //         Console.WriteLine("You can vote too");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You cannot vote");
        //     }


        // int age=45;

        // Console.WriteLine(age>18? "Vote":"Cannot vote");

        // int day=2;
        //     switch (day)
        //     {
        //         case 1:
        //             Console.WriteLine("Sunday");
        //             break;
        //         case 2:
        //             Console.WriteLine("Monday");
        //             break;
        //         case 3:
        //             Console.WriteLine("Tuesday");
        //             break;
                
        //     }

        // int i=1;
        //     while (i < 5)
        //     {
        //         Console.WriteLine(i);
        //         i++;
        //     }

        // for(int i = 0; i < 5; i++)
        //     {
        //         Console.WriteLine(i);
        //     }

        // int i=1;
        //     do
        //     {
        //         Console.WriteLine(i);
        //         i++;
        //     }while(i<5);


        // for (int i = 0; i < 5; i++)
        //     {
        //         Console.WriteLine(i);

        //         for(int j = 0; j < 5; j++)
        //         {
        //             Console.WriteLine(j);
        //         }
        //     }

        // for(int i = 0; i < 5; i++)
        //     {
        //         for(int j = 0; j < 5; j++)
        //         {
        //             Console.Write("*");
        //         }
        //         Console.WriteLine();
        //     }

        // for(int i = 5; i>=1; i--)
        //     {
        //         for(int j = 1; j <=i; j++)
        //         {
        //             Console.Write("*");
        //         }
        //         Console.WriteLine();
        //     }


        // for(int i = 1; i <=5; i++)
        //     {
        //         for(int j = 1; j <=5-i; j++)
        //         {
        //             Console.Write(" ");
        //         }
        //         for(int j = 1; j <= i; j++)
        //         {
        //             Console.Write("*");
        //         }
        //         Console.WriteLine();
        //     }

        
        // string [] friends=["Abc","def","ghu"];

        // foreach(string i in friends)
        //     {
        //         Console.WriteLine(i);
        //     }


        // for(int i = 0; i < 5; i++)
        //     {
        //         if (i == 3)
        //         {
        //             continue;
        //         }
        //         Console.WriteLine(i);
        //     }



        //Arrays

        //string[] cars={"Audi","Lambo","RR","g-wagon"};
        // Console.WriteLine(cars[2]);
        
        // cars[2]="Alto";
        // Console.WriteLine(cars.Length);

        // for(int i=0; i < cars.Length; i++)
        //     {
        //         Console.WriteLine(cars[i]);
        //     }


        // Array.Sort(cars);
        // foreach(string i in cars)
        //     {
        //         Console.WriteLine(i);
        //     }


        //MultiDimensional Array

        int[ , ] nums={{1,2,23,6,7},{43,2,54,3,4}};

        // Console.WriteLine(nums[1,3]);

        // Console.WriteLine(nums[0,2]);

        // nums[0,2]=5;
        // Console.WriteLine(nums[0,2]);

        // foreach(int i in nums)
        //     {
        //         Console.WriteLine(i);
        //     }

        // for(int i = 0; i < nums.GetLength(0); i++)
        //     {
        //         for(int j=0; j < nums.GetLength(1); j++)
        //         {
        //             Console.WriteLine(nums[i,j]);
        //         }
        //     }


        }
    }
}