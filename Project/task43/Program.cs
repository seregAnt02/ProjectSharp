
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значения b1, k1, b2, k2. \r\n");

double b1 = ReadNamberPoint("Введите точку b1: ");
double k1 = ReadNamberPoint("Введите точку k1: ");
double b2 = ReadNamberPoint("Введите точку b2: ");
double k2 = ReadNamberPoint("Введите точку k2: ");

IntersectionLine(b1, k1, b2, k2);

//-------------------------------
// Функция ввода
double ReadNamberPoint(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
//-------------------------------
void IntersectionLine(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x}, {y})");
}
//-------------------------------
