// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
double[] FillArray(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i]=new Random().Next(0,10);
    }
    return array;
}
double SumEvenNumbers(double[] array)
{
    double sum=0;
    foreach (double item in array)
    {
        if(item%2==1)
        sum+=item;
    }
    return sum;
}
Console.WriteLine("Enter the length of the array");
int length=int.Parse(Console.ReadLine());
double[] array = FillArray(length);
Console.WriteLine("Sum of even elements in the array [" + string.Join(", ",array)+"] : "+SumEvenNumbers(array));