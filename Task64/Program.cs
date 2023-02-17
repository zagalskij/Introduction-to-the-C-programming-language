// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string NaturalNumbersUpTo(int number, int i=1)
{
    if (i>number) return String.Empty;
    return NaturalNumbersUpTo(number,i+1) +i+" ";
}
Console.WriteLine("Enter a natural number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumbersUpTo(number));
