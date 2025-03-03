using System;

namespace ConsoleAppMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("7. Выход");

                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение A: ");
                        if (double.TryParse(Console.ReadLine(), out double tempA))
                        {
                            a = tempA;
                            Console.WriteLine($"Значение A установлено как {a}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод!");
                        }
                        break;

                    case "2":
                        Console.Write("Введите значение B: ");
                        if (double.TryParse(Console.ReadLine(), out double tempB))
                        {
                            b = tempB;
                            Console.WriteLine($"Значение B установлено как {b}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод!");
                        }
                        break;

                    case "3":
                        if (a != 0 || b != 0)
                        {
                            Console.WriteLine($"Результат A + B = {a + b}");
                        }
                        else
                        {
                            Console.WriteLine("Значения A и/или B не заданы!");
                        }
                        break;

                    case "4":
                        if (a != 0 || b != 0)
                        {
                            Console.WriteLine($"Результат A - B = {a - b}");
                        }
                        else
                        {
                            Console.WriteLine("Значения A и/или B не заданы!");
                        }
                        break;

                    case "5":
                        if (a != 0 || b != 0)
                        {
                            Console.WriteLine($"Результат A * B = {a * b}");
                        }
                        else
                        {
                            Console.WriteLine("Значения A и/или B не заданы!");
                        }
                        break;

                    case "6":
                        if (a != 0 && b != 0)
                        {
                            if (b != 0)
                            {
                                Console.WriteLine($"Результат A / B = {a / b}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Деление на ноль невозможно.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Значения A и/или B не заданы!");
                        }
                        break;

                    case "7":
                        Console.WriteLine("Выход из программы...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}