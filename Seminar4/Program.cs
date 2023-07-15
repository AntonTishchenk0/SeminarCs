/* Task 1. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

int SumNumb(int numb)
{
    int sum = 0;
    int count = 0;
    while (count <= numb)
    {
        sum = sum + count;  // sum += count;
        count++;
    }
    
    return sum;
}

Console.Write("Input a numb: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Sum of numbers: " + SumNumb(num));
*/

/* Task 2. Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

int Quantity(int number)
{
    int result = 1;
    while(number / 10 > 0)
    {
        number = number / 10;
        result++;
    }
    return result;
  
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of digits: " + Quantity(num));
*/

/* Task 3. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int TheProdOfNumb(int numb)
{
    int result = 1;
    int count = 1;
    while (count <= numb)
    {
        result *= count;
        count++;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("The product of number: " + TheProdOfNumb(num));
*/

/*/ Task 4. 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
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

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);


//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
*/