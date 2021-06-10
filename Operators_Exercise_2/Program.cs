using System;

namespace Operators_Exercise_2
{
    class Program
    {
        public static void AreaOfCircle(int radius)
        {

            (Math.PI * radius * radius)

        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

            if (a == 17 && b == 4)
            {



                Console.WriteLine("What is the radius of your circle");

                var radius = double.Parse(Console.ReadLine());


            }
        }
    }
}
