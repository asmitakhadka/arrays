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
          
            string[] Names = new string[5];
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine($"Enter the name {i + 1}: ");
                Names[i] = Console.ReadLine();
            }
            Console.WriteLine($"The first named entered is {Names[0]}");
            Console.WriteLine($"The last named entered is {Names[4]}");
        }
    }
}
