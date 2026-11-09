using System;

namespace CodesFromBasics
{
    internal class evenODD
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("Both numbers are even");
            }
            else if (a % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine("Both numbers are odd");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("1st number is even, 2nd number is odd");
            }
            else
            {
                Console.WriteLine("1st number is odd, 2nd number is even");
            }
        }
    }
}