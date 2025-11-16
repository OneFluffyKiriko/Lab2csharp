namespace Lab2csharp
{

            /*3. Створити програми для роз’язування задач згідно свого варіанта засобами ООП.
        Введення/виведення даних супроводжувати відповідними повідомленнями. Передбачити
        захист від введення некоректних даних з клавіатури. Виконати завдання двома способами:
        А) З клавіатури вводиться одновимірний масив n цілих чисел.
        Б) Заповнити масив n цілих чисел значеннями за допомогою генератора
        псевдовипадкових чисел з відрізка [-100; 100].*/
        //variant 7
        /*Визначити 1) максимальний за модулем елемент масиву; 2) суму елементів масиву,
        розташованих після останнього нульового елемента.*/
        /*4. Створити та перевірити адекватність тесту до завдання 3(А) згідно вашого варіанту.
        Дані контрольного прикладу підібрати самостійно. У звіті обов’язково вказати обрані вами
        параметри контрольного прикладу у форматі
        Вхідні дані: ....
        Вихідні дані: ....*/

    class IntArrayProcessor
    {
        private int[] arr;

        public IntArrayProcessor(int n)
        {
            arr = new int[n];
        }

        // A) Manual input
        public void InputArrayFromKeyboard()
        {
            Console.WriteLine("Введіть елементи масиву:");

            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    Console.Write($"arr[{i}] = ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                        break;
                    else
                        Console.WriteLine("Помилка! Введіть ціле число.");
                }
            }
        }

        // B) Random fill
        public void FillArrayRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-100, 101); // [-100; 100]
        }

        // 1) Maximum absolute value element
        public int GetMaxAbsolute()
        {
            int maxAbs = Math.Abs(arr[0]);
            int value = arr[0];

            foreach (int x in arr)
            {
                if (Math.Abs(x) > maxAbs)
                {
                    maxAbs = Math.Abs(x);
                    value = x;
                }
            }

            return value; // return the element itself
        }

        // 2) Sum after last zero
        public int SumAfterLastZero()
        {
            int lastZeroIndex = -1;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 0)
                    lastZeroIndex = i;

            if (lastZeroIndex == -1)
                return 0; // no zeros → no sum

            int sum = 0;
            for (int i = lastZeroIndex + 1; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        public void PrintArray()
        {
            Console.WriteLine("\nМасив:");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }

    public static class Task3_5
    {
        public static void Exercise3(string[] args)
        {
            int n;

            // Input size with validation
            while (true)
            {
                Console.Write("Введіть кількість елементів n: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.WriteLine("Помилка! Введіть додатнє ціле число.");
            }

            IntArrayProcessor processor = new IntArrayProcessor(n);

            Console.WriteLine("\nОберіть спосіб заповнення масиву:");
            Console.WriteLine("1 – Введення з клавіатури");
            Console.WriteLine("2 – Випадкові значення [-100; 100]");
            Console.Write("Ваш вибір: ");

            int choice  ;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Помилка! Введіть 1 або 2.");
                Console.Write("Ваш вибір: ");
            }

            if (choice == 1)
                processor.InputArrayFromKeyboard();
            else
                processor.FillArrayRandom();

            processor.PrintArray();

            int maxAbs = processor.GetMaxAbsolute();
            int sumAfterZero = processor.SumAfterLastZero();

            Console.WriteLine($"\n1) Максимальний за модулем елемент: {maxAbs}");
            Console.WriteLine($"2) Сума елементів після останнього нульового: {sumAfterZero}");
        }
    }
}
