/* Task 1. Напишите программу, которая принимает на вход трёхзначное число 
//         и на выходе показывает вторую цифру этого числа.

int ShowSecNum(int number) 
{
    int hundrers = number / 10; 
    int SecondNumber = hundrers % 10;
    return SecondNumber;
}

int ShowSecNum1(int number1)
{
    int units = number1 % 100;
    int SecondNumber = units / 10;
    return SecondNumber;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = ShowSecNum(randNumber);
int randNumber1 = new Random().Next(100, 1000);
int newNumber1 = ShowSecNum1(randNumber1);

Console.WriteLine($"The new random number a {randNumber}, and the second digit is {newNumber}.");
Console.WriteLine($"The new random number a {randNumber1}, and the second digit is {newNumber1}.");
*/
