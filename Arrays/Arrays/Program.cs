using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            String[] FizzBuzz = new string[100];

            for (int i = 0; i <= FizzBuzz.Length; i++)
            {
                if (num % 3 == 0 && num % 5 != 0)
                {
                    Console.Write("Fizz. ");
                }

                if (num % 5 == 0 && num % 3 != 0)
                {
                    Console.Write("Buzz. ");
                }

                else
                {
                    Console.Write(num + ". ");
                }
                num++;
            }
        }
    }
}
