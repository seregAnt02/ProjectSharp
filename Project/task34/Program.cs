// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int size = ReadNamber("Введите размер массива: ");
int[] array = new int[size];

PrintArray(array);

//-------------------------------
void PrintArray(int[] array)
{
    int count = 0;
    string array_str = null;
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = new Random().Next(100, 999);
        if (array[x] % 2 == 0) count++;
        array_str += x != array.Length - 1 ? array[x] + "," : array[x];
    }
    Console.WriteLine($"Массив {array_str}");
    Console.WriteLine($"Количество чётных чисел в массиве {count}");    
}
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}