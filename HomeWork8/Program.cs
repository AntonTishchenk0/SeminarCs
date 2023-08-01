/* Task 1. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void SortMaxToMin(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = array.GetLength(1) - 1; count > 1; count--)
        {
            for (int j = 0; j < count; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
        }
    }
}

Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input minimal value: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input maximal value: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
SortMaxToMin(myArray);
Show2dArray(myArray);*/

/* Task 2. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int MinSumElements(int[,] array)
{
    int row = 1;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minSum += array[0, j];
    int sum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            row = i + 1;
        }
        sum = 0;
    }
    return row;
}

Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input minimal value: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input maximal value: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
int result = MinSumElements(myArray);
Console.WriteLine("The minimal sum is in " + result + " line");*/

/* Task 3. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
*/

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// Task 5. Напишите программу, которая заполнит спирально массив a на b.

