using System;
/* Task 1. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами любые две строки массива.

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

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

Console.Write("Input a number of first row for change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of second row for change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);*/

/* Task 2. Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы.

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

void ChangeSize(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1)) 
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1) ; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
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
Console.WriteLine();

ChangeSize(myArray);
Show2dArray(myArray);*/

/* Task 3. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

int[] FindMinArray(int[,] array)
{
    int min = array[0, 0];
    int minRow = 0;
    int minColumns = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumns = j;
            }
        }
    }
    int[] minArray = {minRow, minColumns};
    return minArray;
}

int[,] DeleteRowAndColumns(int[,] array, int[] minArray)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if(i != minArray[0])
            for(int j = 0, l = 0; j < array.GetLength(1); j++, l++)
            {
                if(j != minArray[1])
                newArray[m,l] = array[i,j];
                else l--;
            }
        else m--;
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
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

int[] coord = FindMinArray(myArray);
ShowArray(coord);
Console.WriteLine();

int[,] result = DeleteRowAndColumns(myArray, coord);
Show2dArray(result);
*/
