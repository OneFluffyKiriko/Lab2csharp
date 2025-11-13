namespace Lab2csharp;

public class Task2
{
    public static void Exercise2(string[] args)
    {
        /* 2. Використовуючи оператори циклу з передумовою та післяумовою, обчислити і вивести на
        екран у табличному вигляді значення функції y = f(x)на заданому інтервалі зміни значень
        аргумента х від а до b з кроком dx.

        За необхідності передбачити виникнення виключних ситуацій 
        (невизначений результат, ділення на нуль, корінь з від’ємного числа,
        логарифмування числа, меншого за нуль тощо). 
        Результати обчислень подати у вигляді наступної таблиці: 
        Результати обчислення функції y = f (x) на проміжку [a, b] з кроком dx .*/

        //variant 7
        // y = cos^2(x)+3sin(x), a = -(pi/2), b = 3pi/2, dx = pi/3.


        double a = -Math.PI / 2;
        double b = 3 * Math.PI / 2;
        double dx = Math.PI / 3;
        Console.WriteLine("Exercise 2.");
        Console.WriteLine("Results of the function y = cos^2(x) + 3sin(x)");
        Console.WriteLine($"for the interval [{a}, {b}] with step {dx:F3}");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine($"|{"x",10} | {"y",15} |");
        Console.WriteLine(new string('-', 45));

        // --- Cycle with precondition (while) ---
        double x = a;
        while (x <= b)
        {
            try
            {
                double y = Math.Pow(Math.Cos(x), 2) + 3 * Math.Sin(x);
                if (double.IsNaN(y) || double.IsInfinity(y))
                    throw new ArithmeticException("Result is undefined");

                Console.WriteLine($"|{x,10:F4} | {y,15:F6} |");
            }
            catch (Exception e)
            {
                Console.WriteLine($"|{x,10:F4} | {"Error: " + e.Message,15} |");
            }
            x += dx;
        }

        Console.WriteLine(new string('-', 45));

        // --- Cycle with postcondition (do-while) ---
        Console.WriteLine("\nThe same calculations but with do-while):");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine($"|{"x",10} | {"y",15} |");
        Console.WriteLine(new string('-', 45));

        x = a;
        do
        {
            try
            {
                double y = Math.Pow(Math.Cos(x), 2) + 3 * Math.Sin(x);
                if (double.IsNaN(y) || double.IsInfinity(y))
                    throw new ArithmeticException("Result is undefined");

                Console.WriteLine($"|{x,10:F4} | {y,15:F6} |");
            }
            catch (Exception e)
            {
                Console.WriteLine($"|{x,10:F4} | {"Error: " + e.Message,15} |");
            }
            x += dx;
        } while (x <= b);

        Console.WriteLine(new string('-', 45));


    }
}
