// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования
double[] FillArray(int number)
{
    double[] array=new double[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Enter array["+i+"]");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
double[] CopyArray(double[] array)
{
    double[] CopyArray=new double[array.Length];
    int i=0;
    foreach (double item in array)
    {
        CopyArray[i]=item;
        i++;
    }
    return CopyArray;
}
Console.WriteLine("Enter the number of elements in the array");
int number = Convert.ToInt32(Console.ReadLine());
double[] array=FillArray(number);
Console.WriteLine(string.Join(" ",array)+" -> "+string.Join(" ",CopyArray(array)));