using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите игру:");
            Console.WriteLine("1. Угадай чx исло");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Num();
                        break;
                    case 2:
                        tabl();
                        break;
                    case 3:
                        div1();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный выбор");
            }
        }
    }

    static void Num()
    {
        Random random = new Random();
        int num1 = random.Next(1, 100);

        Console.WriteLine("Угадайте число от 1 до 100");
        while (true)
        {
            int num2;
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                if (num2 == num1)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {num1}");
                    break;
                }
                else if (num2 < num1)
                {
                    Console.WriteLine("Число больше");
                }
                else
                {
                    Console.WriteLine("Число меньше");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число.");
            }
        }
    }

    static void tabl()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                Console.WriteLine($"{i} x {j} = {result}");
            }
        }
    }

    static void div1()
    {
        Console.WriteLine("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Делители числа {number}:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }
    }
}