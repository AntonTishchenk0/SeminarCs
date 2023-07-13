/* Task 1. Напишите программу, которая принимает на вход число и проверяет, 
// является ли оно палиндромом.

bool Palindrome(int palid)
{
    int origNum = palid;
    int reverseNum = 0;

    while (palid > 0)
    {
        int digit = palid % 10;
        reverseNum = reverseNum * 10 + digit;
        palid = palid / 10;
    }
    return origNum == reverseNum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Palindrome(num);
Console.Write(res);
*/

/* Task 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + 
    (y2 - y1) * (y2 - y1) + 
    (z2 - z1) * (z2 - z1));
    return Math.Round(result, 2);
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distance3D(x1, y1, z1, x2, y2, z2));
*/

/* Task 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void CubeNembers (int number)
{
    int count = 1;
    while (count < number) 
    {
        Console.WriteLine ($"{count} - {count*count*count}");
        count++;
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

CubeNembers(num);
*/
