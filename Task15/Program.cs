// Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
string DayOff(int number)
{
    if (number < 1 || number > 7)
        return "You entered the wrong number!";
    else if (number > 5)
        return "Yes, this day is a day off!";
    else
        return "no this day is not a day off!";
}
Console.WriteLine("Enter the number of the day of the week from 1 to 7: ");
Console.WriteLine(DayOff(int.Parse(Console.ReadLine())));