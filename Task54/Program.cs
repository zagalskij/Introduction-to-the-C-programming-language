// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
double[,] Fill2DArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Enter array[" + i + ","+j+"] : ");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}
double[,] ArrangeTheElementsOfAnArray(double[,] array)
{
    double temp = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j + 1] > array[i, j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
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
            Console.Write(array[i, j]+"\t");
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
ArrangeTheElementsOfAnArray(array);
Console.WriteLine();
PrintArray(array);