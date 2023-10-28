using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");
                Console.WriteLine("5 - Выйти");

                Console.Write("Выберите операцию (1/2/3/4/5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("До свидания!");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Некорректный выбор операции. Попробуйте снова.");
                    continue;
                }

                Console.Write("Введите первое число: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Некорректное число. Попробуйте снова.");
                    continue;
                }

                Console.Write("Введите второе число: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Некорректное число. Попробуйте снова.");
                    continue;
                }

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        break;
                    case "2":
                        result = num1 - num2;
                        break;
                    case "3":
                        result = num1 * num2;
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                }

                Console.WriteLine("Результат: " + result);
                Console.WriteLine("");
            }
        }
    }
}
