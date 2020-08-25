using System;

namespace SwitchCaseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch/Case Exercise Start");
            Console.WriteLine("What is your favoririte subject in school?");
            var answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "math":
                    Console.WriteLine("That's my favorite subject");
                    break;
                case "science":
                    Console.WriteLine("That's a pretty fun subject");
                    break;
                case "gym":
                    Console.WriteLine("Everybody loves gym!!!");
                    break;
                case "history":
                    Console.WriteLine("Who doesn't love history");
                    break;
                case "english":
                    Console.WriteLine("I hated english class");
                    break;
                default:
                    Console.WriteLine($"I am unfamiliar with {answer} class");
                    break;
            }
        }
    }
}
