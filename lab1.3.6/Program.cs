using System;

class Program
{
    static void Main()
    {
        // Создаем два массива
        double[] array1 = { 3, 7, 2, 8, 4 };
        double[] array2 = { 5, 1, 9, 6, 10 };

        // Выводим початковий массив на экран
        array1 = function(array1);
        array2 = function(array2);

        Console.WriteLine("Массив 1:");

        foreach (double element in array1)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("\nМассив 2:");

        foreach (double element in array2)
        {
            Console.Write(element + " ");
        }
    }


    static double[] function(double[] array)
    {
        double max = array[0];
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        for (int i = 0; i < maxIndex; i++)
        {
            array[i] = 0.5;
        }

        return array;
    }
}