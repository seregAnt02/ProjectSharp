

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//---------------------------------
void CreateArray(int[,] array)
{
    int[] mas = new int[array.GetLength(1)];    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        string temp = "", oldValue = "";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,9);

            //Среднее значение столбцов.
            mas[j] += array[i, j];

            oldValue += array[i, j];

            temp += mas[j] + " ";
        }
        Console.WriteLine($"Значения в массиве: {oldValue}");
        if(i == array.GetLength(0) - 1)
            Console.WriteLine($"Суммирование столбцов: {temp}");
    }
}
//---------------------------------
//---------------------------------

int row = ReadNamber("Введите размер массива строк: ");
int column = ReadNamber("Введите размер массива столбцов: ");

int[,] array = new int[row, column];

CreateArray(array);
