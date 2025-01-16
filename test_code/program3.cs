using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Пример матрицы
        int[,] matrix = {
            { 1, -2, 3 },
            { -4, -5, -6 },
            { 7, 8, -9 },
            { -1, -2, -3 }
        };

        // Список для хранения отрицательных элементов
        List<int> negativeElements = new List<int>();
        // Список для хранения номеров строк с полностью отрицательными элементами
        List<int> negativeRows = new List<int>();

        // Перебор строк и столбцов матрицы
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool allNegative = true; // Флаг для проверки, все ли элементы строки отрицательные

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    negativeElements.Add(matrix[i, j]); // Добавляем отрицательный элемент в список
                }
                else
                {
                    allNegative = false; // Если найден неотрицательный элемент, меняем флаг
                }
            }

            // Если вся строка состоит из отрицательных элементов, добавляем номер строки в список
            if (allNegative)
            {
                negativeRows.Add(i);
            }
        }

        // Выводим отрицательные элементы
        Console.WriteLine("Отрицательные элементы матрицы:");
        foreach (var element in negativeElements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Выводим номера строк с полностью отрицательными элементами
        if (negativeRows.Count > 0)
        {
            Console.WriteLine("Номера строк, которые полностью состоят из отрицательных элементов:");
            foreach (var row in negativeRows)
            {
                Console.WriteLine(row);
            }
        }
        else
        {
            Console.WriteLine("Нет строк, которые полностью состоят из отрицательных элементов.");
        }
    }
}

