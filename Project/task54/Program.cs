

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string row = "";
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);

            //SortArray(i, j, array);

            row += array[i, j] + " ";
        }
        
        Console.WriteLine(i + ": " + row);
    }
}

//---------------------------------
// Сортировка массива
void SortArray(int[,] array){    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        string row = "";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j != array.GetLength(1) - 1 ) Rotation(i, j, array);

            row += array[i, j] + " ";
        }

        Console.WriteLine(i + ": " + row);
    }
}

//---------------------------------
void Rotation(int i, int j, int[,] array)
{
    int temp = 0;
    for (int x = j + 1; x < array.GetLength(1); x++)
    {
        if (j != x && array[i, j] < array[i, x])
        {
            temp = array[i, j];
            array[i, j] = array[i, x];
            array[i, x] = temp;
        }
    }
}
//---------------------------------
//---------------------------------
int row = ReadNamber("Введите размер массива строк: ");
int column = ReadNamber("Введите размер массива столбцов: ");

int[,] array = new int[row, column];

CreateArray(array);

Console.WriteLine("--------------------");

SortArray(array);
