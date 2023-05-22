



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int size = ReadNamber("Введите размер массива: ");
int[] array = new int[size];

PrintArray(array);

//-------------------------------
void PrintArray(int[] array)
{
    int sum = 0;
    string array_str = null;
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = new Random().Next(-99, 99);
        if (x % 2 != 0) sum += array[x];
        array_str += x != array.Length - 1 ? array[x] + "," : array[x];
    }
    Console.WriteLine($"Массив {array_str}");
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях. {sum}");    
}
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}