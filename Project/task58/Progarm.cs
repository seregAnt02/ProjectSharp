// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й и 2-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];

Console.WriteLine($"Первая матрица:");
CreateArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
Console.WriteLine($"Вторая матрица:");

CreateArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);

Console.WriteLine($"Произведение первой и второй матриц:");

WriteArray(resultMatrix);

//-------------------------------
//-------------------------------
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
//-------------------------------
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
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
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//-------------------------------
//-------------------------------
