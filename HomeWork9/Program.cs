/* Task 1. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void OutputNaturalNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) OutputNaturalNumbers(number - 1);
}

Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
OutputNaturalNumbers(numb);*/

/* Task 2. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalElements(int m, int n)
{
    if (m > n) return 0;
    else return m + SumNaturalElements(m + 1, n);
}

Console.Write("Input m: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNaturalElements(numb1, numb2));*/

// Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.