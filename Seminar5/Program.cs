/* Task 1. Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

int[] CreateRandArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for(int i =0; i < array.Length; i++)
    {
        if (array[i] < 0) 
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandArray(length, min, max);
int negativeSum = GetNegativeSum(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of negatives is: " + negativeSum); */

// Task 2. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// Task 3. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// Task 4. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].