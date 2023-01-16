// Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
double MAX(double a, double b, double c)
{
    double max = a;
    if (b > max)
        max = b;
    if (c > max)
        max = c;
    return max;
}
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = double.Parse(Console.ReadLine());
Console.Write("max=" + MAX(a, b, c));