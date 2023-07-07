/* Task 1: Напишите программу, которая на вход принимает два числа и выдаёт большее число.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if(num1 > num2)
{
    Console.WriteLine("Maximum number is " + (max = num1));
}
else
{
    Console.WriteLine("Maximum number is " + (max = num2));
}
*/

/* Task 2: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(num2 > max)
{
   max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.Write("Maximun number is " + max);
*/      

/* Task 3: Напишите программу, которая на вход принимает число и выдаёт, 
 является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
*/

/* Task 4: Напишите программу, которая на вход принимает число (Number), 
а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
        current++;
}
*/
