// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);

//-------------------------------
//-------------------------------
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
//-------------------------------
void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                if (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;                    
                }                
            }
        }
    }

    MergingArray(temp);
}
//-------------------------------
void MergingArray(int[] temp)
{
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {

            Console.Write($"X({x}) Y({y}) ");

            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;

                Console.Write($"Z({z})={array3D[x, y, z]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
//-------------------------------
//-------------------------------
