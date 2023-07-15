/* Task 1. Напишите программу, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Exponentiation (int numb1, int numb2)
{
    int result = 1;
    for (int i = 0; i < numb2; i++)
    {
        result *= numb1;
    }
    return result;
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Your number is: " + Exponentiation(num1, num2));*/

/* Task 2. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int Sum(int number)
{
    int sum = 0;
    int count = 0;
    int tempNumber = number;

    while (count < number)
    {
        int number2 = tempNumber % 10;
        sum = sum + number2;
        tempNumber = tempNumber / 10;
        count++;
    }

    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("The sum is equal to: " + Sum(num));
*/

/* Task 3. Напишите программу, которая задаёт массив из m элементов 
// и выводит их на экран. Разработать метод CreateArray(int size), 
// генерирующий массив на основе данных, вводимых пользователем.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

Console.Write("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);*/
