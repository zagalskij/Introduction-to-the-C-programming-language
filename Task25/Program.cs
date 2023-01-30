// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double pow(double a, double b)
{
    double result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine("enter a number");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("enter the degree");
double b = int.Parse(Console.ReadLine());
Console.WriteLine("The number " + a + " to the power of " + b + " is " +pow(a,b));