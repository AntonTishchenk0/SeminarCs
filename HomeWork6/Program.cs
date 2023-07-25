using System;
/* Task 1. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int NumbersMoreNull(int count)
{
    int numberCount = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write("Input a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            numberCount++;
        }
    }
    return numberCount;
}

Console.Write("Input a count numbers: ");
int count = Convert.ToInt32(Console.ReadLine());
int result = NumbersMoreNull(count);
Console.WriteLine($"Count numbers more null: {result}");*/

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossingLine()
{
    Console.Write("Input b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        if (b1 == b2) Console.WriteLine("");
        else Console.WriteLine("");
    }
    else
    {
        double x = (b2-b1) / (k1 - k2);
        double y = k1 * x + b1;
    }
    Console.WriteLine($"Red lines were crossed here: ({x}, {y})");
}
CrossingLine();
