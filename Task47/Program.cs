// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] FillArray(int columns, int rows, double min, double max)
{
    Random rand = new Random();
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(min + rand.NextDouble() * (max - min), 2);
        }
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
Console.WriteLine("Enter the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the minimum element in the array");
double min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the maximum element in the array");
double max = Convert.ToDouble(Console.ReadLine());
PrintArray(FillArray(columns,rows,min,max));
