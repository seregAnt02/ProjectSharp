
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел...\r\n");
Console.Write("Введите значения в переменную a: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите значения в переменную b: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Введите значения в переменную c: ");
int numC = int.Parse(Console.ReadLine());
int max = 0;

if(numA > max) max = numA;
if(numB > max) max = numB;
if(numC > max) max = numC;

Console.Write($"Максимальное число: { max }");
