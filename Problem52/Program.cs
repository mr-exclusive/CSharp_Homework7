//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.Next(minValue, maxValue + 1);
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
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[] FindAverageOfEachColumn(int[,] arr)
{
    double[] arrAverage = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrAverage[j] += arr[i, j];
        }
    }

    for (int i = 0; i < arrAverage.Length; i++)
    {
        arrAverage[i] = Math.Round(arrAverage[i] / arr.GetLength(0), 1);
    }

    return arrAverage;
}

Console.Clear();

Console.Write("Enter number of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in array: ");
int cols = int.Parse(Console.ReadLine()!);

if (rows > 0 && cols > 0)
{
    int[,] array = GetArray(rows, cols, 0, 10);
    PrintArray(array);

    Console.Write($"Average of each column in the array: " + string.Join("; ", FindAverageOfEachColumn(array)));
}
else
{
    Console.Write("Invalid number of rows or columns (must be > 0)!");
}