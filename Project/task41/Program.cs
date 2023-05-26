
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//-------------------------------
//-------------------------------

int arrayLength = ReadNamber("Введите размер массива: ");
int[] ints = new int[arrayLength];
AssigningValue(ints);
//-------------------------------
//Присваивание значения в массиву.
//Чисел > 0
void AssigningValue(int[] array)
{
    int count = 0;
    for(int x = 0; x < array.Length; x++)
    {
        int number = ReadNamber($"Введите число: { x + 1 } ");
        array[x] = number;

        if (number > 0) count++;
    }
    Console.WriteLine($"Чисел больше 0 ввёл пользователь: {count}");
}
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
