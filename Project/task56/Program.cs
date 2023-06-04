

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");

int row = ReadNamber("Введите размер массива строк: ");
int column = ReadNamber("Введите размер массива столбцов: ");

int range = ReadNamber("Введите диапазон: от 1 до ");

int[,] array = new int[row, column];

Console.WriteLine("-------------------------");

CreateArray(array);

Console.WriteLine("-------------------------");

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);

SumMas();

Console.WriteLine($"\n{minSumLine + 1} - строкa элементов с наименьшей суммой = {sumLine}");

//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//-------------------------------
void SumMas()
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);

        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
}
//-------------------------------
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
//-------------------------------
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string message = "";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
            message += array[i, j] + " ";
        }
        Console.Write((i + 1) + ": " + message + "\r\n");
    }
}
//-------------------------------
//-------------------------------
