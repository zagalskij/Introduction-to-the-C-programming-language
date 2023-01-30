// Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
double[] CreateArray(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
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
Console.WriteLine("Enter the length of the array");
OutputAnArray(CreateArray(int.Parse(Console.ReadLine())));