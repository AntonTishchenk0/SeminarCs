/* Task 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowDiapozone(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad ==4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("wrong input!");
}

Console.Write("Input a number of quadrand(from 1 to 4) ");
int quadrand = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrand);
*/

/* Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

static int ShowDiapozone(int cord1, int cord2)
{
    if (cord1 > 0 && cord2 > 0) return 1;
    else if (cord1 < 0 && cord2 < 0) return 3;
    else if (cord1 < 0 && cord2 > 0) return 2;
    else if (cord1 < 0 && cord2 < 0) return 4;
    else return -1;
}

Console.Write("Input x: ");
int cordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int cordinateY = Convert.ToInt32(Console.ReadLine());

int result = ShowDiapozone(cordinateX, cordinateY);
Console.Write("Your quadrand: " + result);
*/

/* Task 3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

double Hypotenuse(int x1, int y1, int x2, int y2) 
{
    double result = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    return result; 
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Hypotenuse(x1, y1, x2, y2));
*/
// Console.WriteLine(Math.Sqrt(25));

/* Task 4. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

static void ShowTablQuad(int quadrand)
{
    int count = 1;
    while (count <= quadrand)
    {
        Console.WriteLine($"{count} - {count*count}");
        count++;
    }
}

Console.Write("input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

ShowTablQuad(num1);
*/
