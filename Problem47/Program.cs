//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double NextDouble(Random random, double minValue, double maxValue)
{
    return random.NextDouble() * (maxValue - minValue) + minValue;
}

double[,] GetDoubleArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(NextDouble(random, minValue, maxValue), 1);
        }
    }

    return result;
}

void PrintArray(double[,] inArray)
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

Console.Clear();

Console.Write("Enter number of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in array: ");
int cols = int.Parse(Console.ReadLine()!);

double[,] array = GetDoubleArray(rows, cols, 0.0, 10.0);
PrintArray(array);