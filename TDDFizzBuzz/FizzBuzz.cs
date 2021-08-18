using System;
namespace TDDFizzBuzz
{
    public sealed class FizzBuzz
    {
        private static FizzBuzz instance = null;

        private FizzBuzz()
        {

        }

        public static FizzBuzz Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FizzBuzz();
                }
                return instance;
            }
        }

        public static string GetNum(int num)
        {
            if (num <= 0 || 100 < num)
            {
                throw new ArgumentException("1から100までの数字を入力してください");
            }
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}
