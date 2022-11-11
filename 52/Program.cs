// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
        
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}


double[] MidleColums(int[,] martix)
{
    double[] result = new double[martix.GetLength(1)];
    for (int i = 0; i < martix.GetLength(1); i++)
    {
        for (int j = 0; j < martix.GetLength(0); j++)
        {
           result[i] += martix[j, i];
        }
        result[i] = Math.Round(result[i]/martix.GetLength(0),1);
    }
    return result;
}


Console.Clear();
Console.WriteLine("Среднее арифметичское элементов каждом столбце: ");
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, colums, 0, 10);
PrintArray(array);
Console.WriteLine("Среднее арифметическое элементов: ");
Console.WriteLine(String.Join($"\t",MidleColums(array)));