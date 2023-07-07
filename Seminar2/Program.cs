/* 
// 12345 / 10 = 1234
// 12345 / 100 = 123     | деление целочисленного 
// 12345 / 1000 = 12
// 12345 / 10000 = 1

// 12345 % 10 = 5
// 12345 % 100 = 45      | выявления остатка
// 12345 % 1000 = 345
// 12345 % 10000 = 2345
*/

/* Task: 1. Напишите программу, которая выводит случайное трёхзначное число 
//         и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundrers = num / 100;
    int units = num % 10;
    int result = hundrers * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

/* Task: 2. Напишите программу, которая принимает на вход число и проверяет, 
//          кратно ли оно одновременно a и b.

bool IsDividable(int num, int a, int b)
{
    if (num % a == 0 && num % b == 0) return true;
    else return false;
}
Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divide: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divide: ");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDividable(number, div1, div2);
Console.WriteLine(result);
*/

/* Task: 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//          и показывает наибольшую цифру числа.
 
 int MaxNumber(int number)
 {
    int num1 = number / 10;
    int num2 = number % 10;
    if (num1 > num2) return num1;
    else return num2;
 }
 int randNumber = new Random().Next(10, 100);
 Console.WriteLine("Random number: " + randNumber);
 int newNumber = MaxNumber(randNumber);
 Console.WriteLine("Maximun number: " + newNumber);
*/

/* Task: 4. Напишите программу, которая принимает на вход два числа и проверяет, 
//          является ли одно число квадратом другого.

bool QvadNumber(int num1, int num2)
{
    if (num1 == num2*num2 || num2 == num1*num1) return true;
    else return false;
}
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = QvadNumber(num1, num2);
Console.WriteLine(result);
*/
