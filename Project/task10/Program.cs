﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."); 
Console.WriteLine("Введите трёхзначное число: ");

var number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        while (number >= 100)
        {
            number /= 10;
        }

        var result = number % 10;

        Console.WriteLine(result);