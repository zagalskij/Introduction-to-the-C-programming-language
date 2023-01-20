// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdNumber(int a)
{
    int result = 0;
    int del = 1;
    int length = a.ToString().Length;
    if (a < 3)
        Console.WriteLine("There is no third digit");
    else
    {
        for (int i = length; i != 3; i--)
        {
            del = del * 10;

        }
        result = a / del % 100 % 10;
    }
    return result;
}
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("The third number:" + ThirdNumber(number));