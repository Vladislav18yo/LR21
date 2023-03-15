using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию (+, -, *, /):");
        char op = Console.ReadLine()[0];

        double result = 0;
        switch (op)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Я чурка 2.0");
                    return;
                }
                result = a / b;
                break;
            default:
                Console.WriteLine("Неверная операция!");
                return;
        }

        Console.WriteLine("Результат: {0}", result);
    }
}
