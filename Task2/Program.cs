// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
double MAX(double a, double b)
{
    if (a > b)
        return a;
    else
        return b;
}
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("max=" + MAX(a, b));