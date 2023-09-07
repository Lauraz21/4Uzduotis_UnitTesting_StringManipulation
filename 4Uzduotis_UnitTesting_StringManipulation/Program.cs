using System;
namespace _4Uzduotis_UnitTesting_StringManipulation
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Iveskite sakini: ");
            string userText = Console.ReadLine();
            Console.WriteLine(ReplacingText(userText));
        }
        public static string ReplacingText(string text)
        {
            return text.Replace("a", "uo").Replace("i", "e");
        }
    }
}
