//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;

class Program
{
    static void Main(string[] args)
    {
        const int arraySize = 5;
        double[] array = new double[arraySize];

        // Заполнение массива вещественными числами
        array[0] = 3.22;
        array[1] = 4.2;
        array[2] = 1.15;
        array[3] = 77.15;
        array[4] = 65.2;

        // Нахождение минимального и максимального элементов
        double min = array[0];
        double max = array[0];
        for (int i = 1; i < arraySize; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }

        // Нахождение разницы между максимальным и минимальным элементами
        double diff = max - min;

        Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами: {diff}");
        Console.ReadLine();
    }
}