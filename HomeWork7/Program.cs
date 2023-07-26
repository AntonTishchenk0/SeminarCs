/* Task 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)  
            array[i,j] = Math.Round(new Random().NextDouble(), 1);
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);*/

/* Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> Числа с такими индексами в массиве нет

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

void ElementValue(int[,] array, int i, int j)
{
    if(i >= 0 && i < array.GetLength(0) && j >= 0 &&
    j < array.GetLength(1))
    {
        int element = array[i, j];
        Console.WriteLine($"Element value: {element}");
    }
    else Console.WriteLine("There is no such element.");
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min positive value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max positive value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);

ElementValue(myArray, i, j);*/

// Task 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[,] Average(int[,] array)
{
    double[,] avg = new double[1, array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        avg[0, j] = sum / array.GetLength(0);
    }
    return avg;
 
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min positive value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max positive value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);

double[,] avgArray = Average(myArray);
Console.Write(avgArray);

