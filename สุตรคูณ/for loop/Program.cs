using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("plese enter numbers for multiplication table.");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Your multiplication table is " + amount + ".");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Loading...");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("completed!!");
            
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(amount + "*" + i + " = " + amount*i );

            }
            Console.ReadLine();

            

        }
    }
}
