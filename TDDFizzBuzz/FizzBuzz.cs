using System;
namespace TDDFizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {

        }

        public string GetNum(int num)
        {
            if (num == 3)
            {
                return "Fizz";
            }
            if (num == 5)
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}
