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
    int i=0;
    double sum=0;
    foreach (double item in array)
    {
        if(i%2==1)
        sum+=item;
        i++;
    }
    return sum;
}
Console.WriteLine("Enter the length of the array");
int length=int.Parse(Console.ReadLine());
double[] array = FillArray(length);
Console.WriteLine("The sum of the elements in the array in odd positions [" + string.Join(", ",array)+"] : "+SumEvenNumbers(array));