using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesFromBasics
{
    internal class UseSwitchCase
    {
        static void Main(string[] args)
        {
            Console.Write("Input the date you will see the day : ");
            int a=Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.Write("Saturday");
                    break;
                case 2: Console.Write("Sunday");
                    break;
                case 3: Console.Write("Monday");
                    break;
                case 4: Console.Write("Tuesday");
                    break;
                case 5: Console.Write("Wednesday");
                    break;
                case 6: Console.Write("Thursday");
                    break;
                case 7: Console.Write("Friday");
                    break;
            }

        }
    }
}
