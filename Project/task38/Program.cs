

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = ReadNamber("Введите размер массива: ");
int[] array = new int[size];

PrintArray(array);

//-------------------------------
void PrintArray(int[] array)
{
    int min = 0, max = 0;
    string array_str = null;
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = new Random().Next(-99, 99);
        if (x == 0)
        {
            min = array[x];
            max = array[x];
        }
        if (array[x] < min) min = array[x];
        if (array[x] > max) max = array[x];
        array_str += x != array.Length - 1 ? array[x] + "," : array[x];
    }
    Console.WriteLine($"Массив {array_str}");
    Console.WriteLine($" Максимальное значение: {max}\r\n Минимальное значение: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = { max - min }"); 
}
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}