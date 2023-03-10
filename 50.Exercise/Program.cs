// /*
// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет
// */

Console.Clear();

System.Console.WriteLine("Введите индекс: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите индекс: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(5, 5, 10, 20);

if (rows < array.GetLength(0) && colums < array.GetLength(1)) Console.WriteLine(array[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

PrintArray(array);


int[,] FillArray(int arrayColumns, int arrayRows, int minValue, int maxValue)
{
    
int[,] filledarray = new int[arrayColumns, arrayRows];
    Random rnd = new Random();

    for (int i = 0; i < filledarray.GetLength(0); i++)
    {
        for (int j = 0; j < filledarray.GetLength(1); j++)
        {
            filledarray[i, j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return filledarray;
}


void PrintArray(int[,] InputArray)
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