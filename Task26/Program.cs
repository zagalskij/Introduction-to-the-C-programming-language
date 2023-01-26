// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int lastnumber(int number)
{
    int count =0;

    for (int i = 0; number>0 ; i++)
    {
        number=number/10;
        count++;
       
    }
    return count;
}
Console.WriteLine("Input number");
int number=int.Parse(Console.ReadLine());
Console.WriteLine("last number is"+lastnumber(number));