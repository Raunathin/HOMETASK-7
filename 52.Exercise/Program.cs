/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();

System.Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n, -99, 99);

System.Console.WriteLine();


for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{sum / array.GetLength(0)} ");
}
Console.ReadLine();

int[,] FillArray(int arrayColumns, int arrayRows, int minValue, int maxValue)
{

    int[,] filledarray = new int[arrayColumns, arrayRows];
    Random rnd = new Random();

    for (int i = 0; i < filledarray.GetLength(0); i++)
    {
        for (int j = 0; j < filledarray.GetLength(1); j++)
        {
            filledarray[i, j] = rnd.Next(minValue, maxValue + 1);
            
            System.Console.Write(filledarray[i, j] + "|");
        }
        System.Console.WriteLine();
    }
    return filledarray;
}


// void PrintArray(double[,] InputArray)
// {
//     for (int i = 0; i < InputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputArray.GetLength(1); j++)
//         {
//             System.Console.Write(InputArray[i, j] + "|");
//         }
//         System.Console.WriteLine();
//     }
// }
