/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

System.Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(m, n, -99, 99);

System.Console.WriteLine();

PrintArray(array);


double[,] FillArray(int arrayColumns, int arrayRows, int minValue, int maxValue)
{
    
double[,] filledarray = new double[arrayColumns, arrayRows];
    Random rnd = new Random();

    for (int i = 0; i < filledarray.GetLength(0); i++)
    {
        for (int j = 0; j < filledarray.GetLength(1); j++)
        {
            filledarray[i, j] = rnd.Next(minValue, maxValue+1) / 10.0;
        }
    }
    return filledarray;
}


void PrintArray(double[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            System.Console.Write(InputArray[i, j] + "|");
        }
        System.Console.WriteLine();
    }
}