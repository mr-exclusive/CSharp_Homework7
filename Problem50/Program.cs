// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве,
// и возвращает позиции значения этого элемента или же указание, что такого числа нет.
// Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//17->такого числа в массиве нет


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

(int row, int col) FindNumberInArray(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                return (i, j);
            }
        }
    }

    return (-1, -1);
}

Console.Clear();

Console.Write("Enter number of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in array: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

(int row, int col) position = FindNumberInArray(array, number);

if (position.row == -1)
{
    Console.Write($"Number {number} is NOT in the array!");
}
else
{
    Console.Write($"Number {number} is found in position ({position.row}, {position.col}).");
}