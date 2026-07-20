using System;

namespace Two
{
    class Program
    {
        static void Main(String [] args)
        {
            // int a=5;
            // int b=6;

            // Console.WriteLine("the sum is: "+(a+b));



        //Math class

        // int a=Math.Max(23,55);
        // Console.WriteLine(a);

            // double b=Math.Abs(36.90);
            // Console.WriteLine(b);


            //String Methods


            // String greet="hello Madhusudan";
            // Console.WriteLine(greet.Length);
            // Console.WriteLine(greet.ToUpper());
            // Console.WriteLine(String.Concat("Madhu","sudan"));

            // String name="Madhusudan";
            // int age=22;
            // Console.WriteLine($"My name is {name} and i am {age} years old");
            
            String hello="Hello guys how you doing";
            Console.WriteLine(hello.IndexOf("guys"));
            Console.WriteLine(hello.Substring(10));
        }
    }
}