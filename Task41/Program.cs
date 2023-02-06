// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
double[] FillArray(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Enter the "+i+"th element of the array");
        array[i]=Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

int GreaterThanZero(double[] array)
{
    int count=0;
   foreach (var item in array)
   {
    if (item>0)
    count++;
   } 
   return count;
}
Console.WriteLine("enter the number of items");
double[] array = FillArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Collection of numbers greater than zero: "+GreaterThanZero(array));