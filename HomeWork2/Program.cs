/* Task 1. Напишите программу, которая принимает на вход трёхзначное число 
//         и на выходе показывает вторую цифру этого числа.

int ShowSecNum(int number) 
{
    int hundrers = number / 10; 
    int SecondDigit = hundrers % 10;
    return SecondDigit;
}

int ShowSecNum1(int number1)
{
    int units = number1 % 100;
    int SecondDigit1 = units / 10;
    return SecondDigit1;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = ShowSecNum(randNumber);
int randNumber1 = new Random().Next(100, 1000);
int newNumber1 = ShowSecNum1(randNumber1);

Console.WriteLine($"The new random number a {randNumber}, and the second digit is {newNumber}.");
Console.WriteLine($"The new random number a {randNumber1}, and the second digit is {newNumber1}.");
*/

/* Task 2. Напишите программу, которая выводит третью цифру заданного числа.

int OutputThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number >= 1000)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

int randNumber = new Random().Next();
int newNumber = OutputThirdDigit(randNumber);

Console.WriteLine($"Random number is {randNumber}, Third digit is {newNumber}");
*/

/* Task 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekNumber(int number)
{
    if (number == 6) return true;
    if (number == 7) return true;
    else return false;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = WeekNumber(number);
Console.Write(result);
*/
