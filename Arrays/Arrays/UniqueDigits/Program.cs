using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random rand = new Random();
            bool unique = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 50);   
            }
            for (int i = 1; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    unique = true;
                    if (arr[i] == arr[j] && arr[j] <= 50)
                    {
                        arr[j] = arr.Length + 1;
                        unique = false;
                    }
                }
                

                /*for (int j = i - 1; j >= 0; j--)
                {
                    unique = true;
                    if (arr[i] == arr[j] && arr[j] <= 50)
                    {
                        arr[j] = arr.Length + 1;
                        unique = false;
                    }
                }*/

                if (unique == false)
                {
                    arr[i] = arr.Length + 1;
                }
            }
            foreach (int index in arr)
            {
                if (index <= arr.Length)
                {
                    Console.WriteLine(index);
                }
            }
        }
    }
}
