

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

int numberA = ReadNamber("Введите число A: ");
int numberB = ReadNamber("Введите число B: ");
ToDegree(numberA, numberB);

//-------------------------------
//-------------------------------
// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int x = 1; x <= b; x++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}

//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
