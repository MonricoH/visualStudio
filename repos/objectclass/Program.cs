using System;

namespace objectclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            string name = cat.name;
            Console.WriteLine(name);

            cat.Meow("am i going to roll");
            Console.WriteLine();


            Console.Read();

        }

    }
    public class Cat
    {
        public string name = "pussycat";
        public string color;
        public string ey_color;

        public void Meow(String Roll)
        {
            Console.WriteLine(Roll);
        }
    }
}
