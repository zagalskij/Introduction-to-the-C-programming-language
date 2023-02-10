// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9
double[,] FillArray(int columns, int rows)
{
    double[,] array = new double[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write("Enter array["+i+","+j+"] : ");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}
void FindNumber(double[,] array, int columns, int rows)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (columns == i && rows == j)
            {
                Console.WriteLine("array["+i+","+j+"] : "+array[i, j]);
                return;
            }
        }
    }
    Console.WriteLine("There is no such element");
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i, j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("enter the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
double[,] array = FillArray(columns, rows);
Console.WriteLine("Enter the column number");
int IndexColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the row number");
int IndexRows = Convert.ToInt32(Console.ReadLine());
FindNumber(array,IndexColumns,IndexRows);