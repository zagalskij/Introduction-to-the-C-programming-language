
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

double[] CreateArray(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write("Enter the " + i + "th element: ");
        mas[i] = double.Parse(Console.ReadLine());
    }
    return mas;
}
void OutputAnArray(double[] array)
{
    Console.Write("[");
    foreach (double item in array)

        Console.Write(item + ", ");

    Console.Write("\b\b]");
}
double[] reverse(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;


    return array;
}
Console.WriteLine("Enter the length of the array");
OutputAnArray(reverse(CreateArray(int.Parse(Console.ReadLine()))));