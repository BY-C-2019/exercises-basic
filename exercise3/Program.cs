using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Second Name: ");
            string secondName = Console.ReadLine();
            Console.WriteLine(
                StoryFromNames(firstName, secondName));
            Console.ReadKey();
        }

        public static string StoryFromNames(string firstName, string secondName)
        {
            string story = firstName;
            story += " went for a walk with ";
            story += secondName;

            return story;
        }
    }
}
