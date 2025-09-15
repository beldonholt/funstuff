// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//------------------------------------------Himanshu
Console.WriteLine("Hello to our github project");
Console.WriteLine("In this we are three peoples working on same project");
Console.WriteLine("We have created a new repo");

namespace LAB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1");
            string input = Console.ReadLine();
            int Number1 = int.Parse(input);

            Console.WriteLine("Enter Number2");
            string input2 = Console.ReadLine();
            int Number2 = int.Parse(input2);

            Console.WriteLine("Enter Number3");
            string input3 = Console.ReadLine();
            int Number3 = int.Parse(input3);

            // check ascending order

            if ((Number1 < Number2) && (Number2 < Number3))
            {
                Console.WriteLine($"Your numbers are in ascending order: {Number1} {Number2} {Number3}");
            }
            else
            {
                if ((Number1 > Number2) && (Number2 > Number3))
                {
                    Console.WriteLine("Numbers are entered in  descending order");
                }
                else
                {
                    Console.WriteLine("Numbers are not in order");
                }
            }


            Console.ReadLine();
        }
    }
}


//------------------------------------------Rami
RamiGreeting();

// Method defined for Rami
void RamiGreeting()
{
    Console.WriteLine("Hello from Rami!");
}
//------------------------------------------Celeste
static void funThings()
{
    Console.WriteLine("hi I'm fun things");
    Console.WriteLine("i can do many things, like counting to 100. See!");
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"{i}");
    }
}
funThings();