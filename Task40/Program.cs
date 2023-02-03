//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существоваит треугольник с сторонами такой длины.

bool TheExistenceOfATriangle(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < b + a)
        return true;
    else
        return false;
}
Console.WriteLine("enter side A");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("enter side B");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("enter side C");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("TheTriangleExists :" + TheExistenceOfATriangle(a, b, c));
