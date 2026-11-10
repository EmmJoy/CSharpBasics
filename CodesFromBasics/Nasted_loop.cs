using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesFromBasics
{
    internal class Nasted_loop
    {
        static void Main(string[] args)
        {
            // Use nested for loops to print 4 rows, each containing 4 stars.

            //Console.Write("Enter the row number that you want :   ");

            //int row = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the row number that you want :   ");
            //int collum = Convert.ToInt32(Console.ReadLine());

            //Console.Write("give your symbol");
            //var symbol = Console.ReadLine();

            //for (int i = 0; i < row; i++)
            //{
            //    for(int j = 0; j < collum; j++)
            //    for(int j = 0; j < collum; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}


            Console.Write("Enter the row number that you want :   ");

            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the row number that you want :   ");
            int collum = Convert.ToInt32(Console.ReadLine());

            Console.Write("give your symbol");
            var symbol = Console.ReadLine();

            for (int i = 0; i < row; i++)
            {
                
                   for (int j = 0; j < collum; j++)
                    {
                        Console.Write(row);
                    }
                Console.WriteLine();
            }

        }
    }
}
