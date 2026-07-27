 using System;    //System is args namespace  that contains different built in classes that can be used

namespace HelloWorld //namespace is also container for different classes
{
    class Program
    {
        static void Main(String[] args)
        {
            // int age=22;
            // datatypes in c#= int,char,string,bool,double
            // string name=Console.ReadLine();
            // float weight=75.44F;
            // Console.WriteLine("Hello  i am Madhusudan and i am "+age+"years old and my weight is"+weight);
            // Console.WriteLine("you entered"+name);

            //Typecasting

            //internal typecasting

            // int x=4;
            // Console.WriteLine(x);

            // float y=x;
            // Console.WriteLine(y);

            //Explicit typecasting
            // float a=5.6F;
            // int x= (int)a;
            // Console.WriteLine(x);

            string age=Console.ReadLine();

            Console.WriteLine("Next year you will be "+(Convert.ToInt16(age)+(int)1));
            





        }
    }
} 