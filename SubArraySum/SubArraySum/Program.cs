using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the sum");
            int givenSum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int j = i + 1;
                sum = arr[i];
                while (j < n)
                {
                    sum += arr[j];
                    if (sum == givenSum)
                    {
                        i += 1;
                        j += 1;
                        Console.WriteLine(i + " " + j);
                        n = 0;
                    }
                    j++;
                }
                j = i + 1;
                sum = 0;
            }
        }
    }
}