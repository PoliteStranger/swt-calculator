//See httusing System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine($"Test add {calc.Add(2, 4)}");
            Console.WriteLine($"Test pow {calc.Power(2, 3)}");

            //ineffecient testing, not reusable!
            //not scalable!!
        }
    }
}