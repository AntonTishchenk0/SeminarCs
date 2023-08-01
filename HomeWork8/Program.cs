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

int[,] MatrixMulti(int[,] matrix1, int[,] matrix2)
{
    int[,] array = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int m = 0; m < matrix1.GetLength(1); m++)
                    array[i, j] += matrix1[i, m] * matrix2[m, j];

    }
    else Console.WriteLine("The operation is impossible!");
    return array;
}

Console.WriteLine("Input number of rows (1st matrix): ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns (1st matrix): ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of rows (2nd matrix): ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns (2nd matrix): ");
int col2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandom2dArray(rows1, col1, minValue, maxValue);
int[,] matrix2 = CreateRandom2dArray(rows2, col2, minValue, maxValue);
Console.WriteLine();
Show2dArray(matrix1);
Console.WriteLine();
Show2dArray(matrix2);
Console.WriteLine();
int[,] result = MatrixMulti(matrix1, matrix2);
Show2dArray(result);*/

/* Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3DArray(int length, int width, int height)
{
    int[,,] array = new int[length, width, height];
    if (length * width * height <= 90)
    {
        int step = 90 / (length * width * height);
        int temp = 10 - step;
        for (int i = 0; i < length; i++)
            for (int j = 0; j < width; j++)
                for (int m = 0; m < height; m++)
                {
                    array[i, j, m] = temp + step;
                    temp += step;
                }
        return array;
    }
    else
    {
        Console.WriteLine("Impossible!");
        int[,,] noArray = new int[1, 1, 1];
        return noArray;
    }
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
                Console.Write($"{array[i, j, m]} ({i},{j},{m})");
            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.WriteLine("Input length of array: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input width of array: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input height of array: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3DArray(x, y, z);
Show3DArray(myArray);*/

/* Task 5. Напишите программу, которая заполнит спирально массив a на b.

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] FillSpiralArray(int rows, int columns)
{
    int temp = 1;
    int[,] array = new int[rows, columns];
    for (int l = 0, k = 0; k < rows && l < rows; l++, k++)
    {
        for (int j = l, i = k; j < columns; j++)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int i = k, j = columns - 1 - l; i < rows - k; i++)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int j = columns - 1 - l, i = rows - 1 - k; j >= l; j--)
            if (array[i, j] == 0) array[i, j] = temp++;
        for (int i = rows - 1 - k, j = l; i > k; i--)
            if (array[i, j] == 0) array[i, j] = temp++;
    }
    return array;
}

Console.WriteLine ("Input number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());


int[,] spiralArray = FillSpiralArray(rows, columns);
Show2dArray(spiralArray);*/
