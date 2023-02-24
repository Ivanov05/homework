using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wensday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Warking day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekemd");
                    break ;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
