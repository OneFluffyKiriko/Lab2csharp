
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using Lab2csharp;


namespace Lab2csharp;
class Program
{
    public static void Main(string[] args)
    {
        int menuControl = 1;
        while(menuControl != 0)
        {   
            Console.WriteLine("Select task for Lab1: ");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            string menuInput = Console.ReadLine();
            menuControl = int.Parse(menuInput);
            switch (menuControl)
            {
                case 0: Console.WriteLine ("Exiting"); break;
                case 1: Task1.Exercise1(args); break;
                case 2: Task2.Exercise2(args); break;
                case 3: Task3_5.Exercise3(args); break;
                default: Console.WriteLine("You chose wrong!!!"); break;
            }
        } 
    }
}
