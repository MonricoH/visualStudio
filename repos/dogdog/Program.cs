using System;

namespace dogdog
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 bobby = new Class1();

            bobby.Color = "Yellow";
            bobby.Eye_color = "Brown";
            bobby.h = "17";
            bobby.len = "45 in";
            bobby.we = "23 pound";

            Console.WriteLine(bobby .Color);
            Console.WriteLine(bobby.Eye_color);
            Console.WriteLine(bobby.h);
            Console.WriteLine(bobby.len);
            Console.WriteLine(bobby.we);
           
            bobby.Sit("imgoin");



        }
    }
}
