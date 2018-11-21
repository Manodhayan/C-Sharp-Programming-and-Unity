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
            Console.WriteLine("Hey! Welcome to the Game! ");
            Console.Write("∗∗∗∗∗∗∗∗∗∗∗∗∗∗\nMenu:\n1−NewGame\n2−LoadGame\n3−Options\n4−Quit\n∗∗∗∗∗∗∗∗∗∗∗∗∗∗\nYour Choice:");
            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Console.WriteLine("Creating New Game...");
                    break;
                case 2:
                    Console.WriteLine("Loading Game...");
                    break;
                case 3:
                    Console.WriteLine("Your Option aren't set yet!");
                    break;
                case 4:
                    Console.WriteLine("GoodBye!");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }


            Console.ReadLine();
        }
    }
}
