// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int sum(int a)
{
    int LastNumber = a % 10;
    int sum = 0;
    double length = Math.Log10(a) + 1;
    for (int i = 1; i < length; i++)
    {
        sum += LastNumber;
        a = a / 10;
        LastNumber = a % 10;
    }
    return sum;
}
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("the sum of the numbers in the number " + number+ " is " + sum(number));