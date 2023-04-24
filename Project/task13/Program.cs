// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет."); 
Console.WriteLine("Введите число: ");

var number = Convert.ToInt32(Console.ReadLine());

if(number < 100) Console.WriteLine("третьей цифры нет");

if(number > 100 && number < 1000)
    {        
        var result = number % 10;

        Console.WriteLine($"третья цифра: {result}");
    }

if (number >= 1000)
    {

        while (number >= 1000)
        {
            number /= 10;
        }

        var result = number % 10;

        Console.WriteLine($"третья цифра: {result}");
    }    