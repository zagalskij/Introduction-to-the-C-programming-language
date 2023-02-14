// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка
double[,] Fill2DArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Enter array[" + i + "," + j + "] : ");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}
int FindTheRowWithTheSmallestSumOfElements(double[,] array)
{
    double sum = 0;
    double[] sumArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
        sum = 0;
    }
    int indexMin = 1;
    double min = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++)
        if (min > sumArray[i])
        {
            min = sumArray[i];
            indexMin = i + 1;
        }
    return indexMin;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the numbers of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numbers of columns");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = Fill2DArray(rows, columns);
PrintArray(array);
Console.WriteLine("The smallest row with the sum of elements is: "
+ FindTheRowWithTheSmallestSumOfElements(array));