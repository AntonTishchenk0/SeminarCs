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
