// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
double[,] FillSnakeArray()
{
    double[,] array = new double[4, 4];
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        Console.WriteLine("Enter the array[" + i + "," + j + "]");
        array[i, j] = Convert.ToDouble(Console.ReadLine());
        count++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
     return array;
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
PrintArray(FillSnakeArray());