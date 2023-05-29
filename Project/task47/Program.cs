
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//---------------------------------
void CreateArray(double[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string temp = "";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble(), 1);            
            temp += array[i, j] + " ";            
        }
        Console.WriteLine(temp + "\r\n");
    }
}
//---------------------------------
//---------------------------------

int row = ReadNamber("Введите размер массива строк: ");
int column = ReadNamber("Введите размер массива столбцов: ");

double[,] array = new double[row, column];

CreateArray(array);
