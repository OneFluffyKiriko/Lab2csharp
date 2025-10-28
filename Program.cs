// See https://aka.ms/new-console-template for more information
//Написати програму, яка виводить назву знака зодіака за його порядковим номером.
using System;


namespace Labwork2
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 1;
            switch (a)
            {
                case 1: Console.WriteLine("Aries"); break;
                case 2: Console.WriteLine("Taurus"); break;
                case 3: Console.WriteLine("Gemini"); break;
                case 4: Console.WriteLine("Cancer"); break;
                case 5: Console.WriteLine("Leo"); break;
                case 6: Console.WriteLine("Virgo"); break;
                case 7: Console.WriteLine("Libra"); break;
                case 8: Console.WriteLine("Scorpio"); break;
                case 9: Console.WriteLine("Sagittarius"); break;
                case 10: Console.WriteLine("Capricorn"); break;
                case 11: Console.WriteLine("Aquarius"); break;
                case 12: Console.WriteLine("Pisces"); break;
                default: Console.WriteLine("Incorrect input"); break;
            }
        
        }
    }
}