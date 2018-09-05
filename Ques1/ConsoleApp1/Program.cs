using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("****Welcome to the CrankWorx Medal Awards****");
            Console.WriteLine("*********************************************");

            string[] medalwinner = new string[3];
            Console.WriteLine("Enter the name of GOLD medal winner");
            medalwinner[0] = Console.ReadLine();
            Console.WriteLine("Enter the name of SILVER medal winner");
            medalwinner[1] = Console.ReadLine();
            Console.WriteLine("Enter the name of BRONZE medal winner");
            medalwinner[2] = Console.ReadLine();

            Console.WriteLine("Which medal holder would you like to see displayed");
            Console.WriteLine("Press 0 for the gold medal winner");
            Console.WriteLine("Press 1 for the silver medal winner");
            Console.WriteLine("Press 2 for the bronze medal winner");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine($"(Gold medal winner is: {medalwinner[0]})");
            }
            else if (input == 1)
            {
                Console.WriteLine($"(Silver medal winner is: {medalwinner[1]})");
            }
            else if (input == 2)
            {
                Console.WriteLine($"(Bronze medal winner is: {medalwinner[2]})");
            }
        }
    }
}
