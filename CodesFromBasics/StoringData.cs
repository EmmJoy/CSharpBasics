using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesFromBasics
{
    internal class StoringData
    {
        static void Main(string[] args)
        {
            //Storing Data


            Console.Write("Enter your name :  ");
            var name = Console.ReadLine();

            Console.Write("Enter your num :  ");
            var num = Console.ReadLine();

            Console.Write("Enter your age :  ");
            var age = Console.ReadLine();

            Console.WriteLine("Name is  : " + name);
            if (num.Length == 11)
            {
                Console.WriteLine("Number is :" + num);
            }
            else
            {
                Console.WriteLine("Please Enter Your Valid Number");
            }

            Console.WriteLine("Age is  : " + age);
        }
    }
}
