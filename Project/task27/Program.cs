
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

int number = ReadNamber("Введите число : ");
Console.WriteLine(SumNumber(number));

//-------------------------------
//-------------------------------

int SumNumber(int number){
    int sum = 0, temp = 0;
    while(number > 0){
        temp = number % 10;
        sum += temp;
        number /= 10;
    }
    return sum;
}
//-------------------------------
// Функция ввода
int ReadNamber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//-------------------------------