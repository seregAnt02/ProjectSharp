
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int size = ReadNamber("Введите размер массива: ");
int[] array = new int[size];
PrintArray(array);

//-------------------------------
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//-------------------------------
// Присваивание случайного значения и вывод массива в консоль.
void PrintArray(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = new Random().Next(0, 9);
        Console.Write(array[x]);
    }
}