/* Task 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ReverseArray (int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;

//     }
// }

void ReverseArray (int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

    }
}

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
ReverseArray(myArray);
ShowArray(myArray);*/

/* Task 2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

bool Triangle(int[] array)
{
    
    if ((array[0] < array[1] + array[2]) &&
    (array[1] < array[2] + array[0]) &&
    (array[2] < array[0] + array[1])) return true;
    else return false;
      
}

Console.Write("Input a side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c side: ");
int c = Convert.ToInt32(Console.ReadLine());
int[] array = {a, b, c};

bool result =  Triangle(array);
Console.Write(result);*/

/* Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

int[] CreateRandArray(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

int[] myArray = CreateRandArray(length);
ShowArray(myArray);*/

/* Task 4. Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] CopyArray(int[] Array1)
{
    int[] Array2 = new int[Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
        Array2[i] = Array1[i]; 
    
    return Array2;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Array1 = {1, 2, 3, 4, 5, 6};
ShowArray(Array1);

int[] myArray = CopyArray(Array1);
ShowArray(myArray);*/
