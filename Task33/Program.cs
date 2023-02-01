// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
double[] CreateArray(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = new Random().Next(1,346);
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
bool find(double number, double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         if (Math.Abs(array[i])==Math.Abs(number))
         return true;
       
    }
    return false;
}
Console.WriteLine("Enter the length of the array");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the desired number");
double FindNumber=double.Parse(Console.ReadLine());
double[] mas = CreateArray(length);
OutputAnArray(mas);
Console.WriteLine();
Console.WriteLine("The desired number is present in the array: " + find(FindNumber,mas));