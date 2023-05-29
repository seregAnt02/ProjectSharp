
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

//---------------------------------
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//---------------------------------

void CreateArray(int[,] array, int index)
{
    bool flag = false;    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string temp = "";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);

            temp += array[i, j];

            if (j == index)
            {
                Console.WriteLine($"В массиве i: {i}, значение: {array[i, j]}");
                flag = true;
            }
            if (!flag && j == array.GetLength(1) - 1) Console.WriteLine($"В массиве i: {i}, такого элемента нет");
        }
        Console.WriteLine($"Массив: {temp} ");
    }
}
//---------------------------------
//---------------------------------
int row = ReadNamber("Введите размер массива строк: ");
int column = ReadNamber("Введите размер массива столбцов: ");
int index = ReadNamber("Введите позицию элемента: ");

int[,] array = new int[row, column];

CreateArray(array, index);

//---------------------------------
