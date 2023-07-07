// Console.WriteLine("Hello, World!);

// int a = 25;
// double b = 14.5;
// string c = "Hello, World!";
// bool d = true; //false;

// int num1 = 5;
// int num2 = 7;

// Console.WriteLine("My numbers is " + num1 + ", and " + num2 + ", and it is good");
// Console.WriteLine($"My numbers are {num1}, and {num2}, and it is good");

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your number is " + num);

/* Task 1: Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.

using System.Globalization;

Console.Write("Input is first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input is second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int qvad2 = num2 * num2;

if(num1 == qvad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/* Task 2: Напишите программу, которая на вход принимает одно число (Number), 
а на выходе показывает все целые числа в промежутке от -Number до Number.

Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/
