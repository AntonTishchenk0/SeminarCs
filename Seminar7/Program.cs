using System;
/* Task 1. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

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
*/

/* Task 2. Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.

int [,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            array[i,j] = i + j;
    }
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

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dArray(rows, columns);

Show2dArray(array);*/

/* Task 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

void Transform2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(i % 2 == 0 && j % 2 == 0)
                array[i,j] *= array[i,j];
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
Console.WriteLine();

Transform2dArray(myArray);
Show2dArray(myArray);*/

/* Task 4. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int SumElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i,i];
    return sum;    
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
Console.WriteLine();
int result = SumElements(myArray);
Console.Write(result);*/
