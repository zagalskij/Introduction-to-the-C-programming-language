//Напишите программу которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10 

int[] FillArray(int number)
{
    int[] mas = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write("Enter the " + i + " element: ");
        mas[i] = int.Parse(Console.ReadLine());
    }
    return mas;
}

void FromDecimalToBinary(int number)
{
if (number ==1)
{Console.Write(1);
return;}
FromDecimalToBinary(number/2);
Console.Write(number%2);
}
Console.WriteLine("Enter a number in decimal notation");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write(number+" -> ");
FromDecimalToBinary(number);