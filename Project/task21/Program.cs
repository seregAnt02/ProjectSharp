
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    //d = √((хА – хВ)2 + (уА – уВ)2)
    Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
    
    Console.WriteLine("Введите координаты для точки А: ");
    Console.WriteLine("по x1: ");
    double ax = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("по y1: ");
    double ay = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("по z1: ");
    double az = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты для точки В: ");
    Console.WriteLine("по x2: ");
    double bx = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("по y2: ");
    double by = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("по z2: ");
    double bz = Convert.ToDouble(Console.ReadLine());

    double distans = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));

    Console.WriteLine($"Расстояние между А и В = {Math.Round(distans, 2)}");

