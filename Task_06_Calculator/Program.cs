using System.Text;
using System;

namespace Task_06_Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int operand1 = 0, operand2 = 0;

        Console.WriteLine("Введіть значення першого операнду:");
        while (!int.TryParse(Console.ReadLine(), out operand1))
            Console.WriteLine("Ви ввели некоректне значення операнду, спробуйте знову");
        
        Console.WriteLine("Введіть значення другого операнду:");
        while (!int.TryParse(Console.ReadLine(), out operand2))
            Console.WriteLine("Ви ввели некоректне значення операнду, спробуйте знову");

        Console.WriteLine("Введіть знак арифметичної операції для обчислення:");

    NewTry:
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "+":
                Console.WriteLine($"Операція додавання = {operand1 + operand2}");
                break;
            case "-":
                Console.WriteLine($"Операція віднімання = {operand1 - operand2}");
                break;
            case "*":
                Console.WriteLine($"Операція множення = {operand1 * operand2}");
                break;
            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine("На нуль ділити не можна!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Операція поділу = {(double)operand1 / operand2}");
                    break;
                }
            case "%":
                if (operand2 == 0)
                {
                    Console.WriteLine("На нуль ділити не можна!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Операція залишку від поділу = {operand1 % operand2}");
                    break;
                }
            default:
                Console.WriteLine("Ви ввели неправильний знак арифметичної операції, спробуйте знову");
                goto NewTry;
                //break;
        }

        Console.ReadKey();
    }
}

