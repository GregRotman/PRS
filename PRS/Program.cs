using PRS.Engine;
using System;

namespace PRS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            GameEngine myEngine = new GameEngine(2);
            Console.WriteLine($"My current player count is {myEngine.GetPlayerCount()}");
            myEngine.AddPlayer();
            Console.WriteLine($"My current player count is {myEngine.GetPlayerCount()}");


            var exitText = "";
            while (string.Equals(exitText, "E", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.WriteLine("Type 'E' to exit");
                exitText = Console.ReadLine();
            }
        }
    }
}
