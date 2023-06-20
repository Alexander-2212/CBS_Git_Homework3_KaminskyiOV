using System.Text;

namespace Task_03;

class Program
{
    static void IncreaseArrayLength(ref int[] array)
    {
        int[] tempArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length + 1; i++)
        {
            if (i <= array.Length - 1)
            {
                tempArray[i] = array[i];
            }
            else
            {
                tempArray[i] = 0;
            }
        }
        array = tempArray;
    }

    static int[] AddValueToArray(int[] array, int value)
    {
        int[] tempArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length + 1; i++)
        {
            if (i == 0)
            {
                tempArray[i] = value;
            }
            if ((i > 0) && (i <= array.Length))
            {
                tempArray[i] = array[i - 1];
            }
        }

        return tempArray;
    }

    public static string ToCsvText(int[][] array)
    {
        string output = "";

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                output += array[i][j];
                if (j != array[i].Length - 1) { output += ","; }
            }
            if (i != array.Length - 1) { output += "\n"; }
        }

        return output;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Введіть розмір масиву:");

        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Random random = new Random();

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
            Console.Write($"{array[i]} ");
        }

        IncreaseArrayLength(ref array);

        Console.WriteLine("\nМасив після збільшення довжини на 1:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("\nВведіть аргумент для додавання до масиву за індексом 0");

        int value = int.Parse(Console.ReadLine());

        int[] array2 = AddValueToArray(array, value);

        Console.WriteLine("Масив після доданого аргументу:");

        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write($"{array2[i]} ");
        }

        Console.ReadKey();
    }
}

