// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdNumber(int a)
{
    return a%100%10;

}
Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("You entered a non-three-digit number");
}
else
    Console.WriteLine("The third number:" + ThirdNumber(number));