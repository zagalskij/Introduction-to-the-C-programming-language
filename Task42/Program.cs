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

int FromDecimalToBinary(int number)
{

if (number ==0)
return 0;
number%2;
return FromDecimalToBinary(number/2);

}
Console.WriteLine(FromDecimalToBinary(45));