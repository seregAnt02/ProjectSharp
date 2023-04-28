
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да

    Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("Введите число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    int[] masAdd(int number)
    {
        var mas = new int[5];
        int index = 0;
        while (number > 0)
        {
            mas[index] = number % 10;
            number /= 10;
            index++;
        }

        return mas;
    }

    bool IsPalindrom(int number)
    {
        var mas = masAdd(number);
        for (int firstIndex = 0, lastIndex = mas.Length - 1; firstIndex < lastIndex; ++firstIndex, --lastIndex)
        {
            if (mas[firstIndex] != mas[lastIndex]) return false;
        }

        return true;
    }

    if(IsPalindrom(number)) Console.WriteLine("да");
    if (!IsPalindrom(number)) Console.WriteLine("нет");



