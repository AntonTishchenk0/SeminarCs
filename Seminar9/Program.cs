using System;
/* Task 1. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

void OutputNaturalNumbers(int number)
{
    if (number > 1) OutputNaturalNumbers(number - 1);
    Console.Write(number + " ");
}

Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
OutputNaturalNumbers(numb);*/

/* Task 2. Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.

int ReturnSumOfDigits(int number)
{
    if (number != 0) return ReturnSumOfDigits(number / 10) + number % 10;
    return 0;
}

Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReturnSumOfDigits(numb));

/* f(1234) -> f(123) + 4
// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> f(0) + 1
// f(0) -> 0
// f(1) -> 0 + 1 = 1
// f(12) -> 1 + 2 = 3
// f(123) -> 3 + 3 = 6
/* f(1234) -> 6 + 4 = 10
*/

/* Task 3. Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

void OutputNaturalNumbers(int m, int n)
{
    if (m > n) 
    {
        Console.Write(m + " ");
        OutputNaturalNumbers(m - 1, n);
    }
    else if (m < n) 
    {
        Console.Write(m + " ");
        OutputNaturalNumbers(m + 1, n);
        
    }
    else Console.Write(m + " ");
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
OutputNaturalNumbers(m, n);*/

/* Task 4. Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B.

double RaiseToDegree(double num, int pow)
{
    if ( pow > 0) return RaiseToDegree(num, pow - 1) * num;
    else if (pow < 0) return RaiseToDegree(num, pow + 1) / num;
    else return 1;
}

Console.Write("Input a number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a power: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.Write(RaiseToDegree(num, pow));*/
