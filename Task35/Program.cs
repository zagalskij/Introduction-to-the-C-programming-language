// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов
//  массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении 
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
double[] CreateArray(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = new Random().Next(1,346);
    }
    return mas;
}
int NumberOfElements(double a,double b, double[] array)
{
    int count = 0;
    foreach (double item in array)
    {
        if (item>=a && item<=b)
        count++;
    }
    return count;
}
double[] mas = CreateArray(123);
Console.Write("[");
Console.Write(string.Join(", ",mas));
Console.Write("] -> ");
Console.WriteLine(NumberOfElements(10,99,mas));