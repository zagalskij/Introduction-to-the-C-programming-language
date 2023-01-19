// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondNumber(int a)
{
    return a % 100 / 10;

}
Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("You entered a non-three-digit number");
}
else
    Console.WriteLine("The second number:" + SecondNumber(number));