using System;

namespace TDDFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = FizzBuzz.Instance;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.GetNum(i));
            }
        }
    }
}
