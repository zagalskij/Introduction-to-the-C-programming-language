// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] FillArray(int columns, int rows)
{
    int[,] array = new int[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write("Enter array["+i+","+j+"] : ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}
void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
          double sum=0;
        for (int i=0 ; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
                    Console.Write(sum/array.GetLength(0)+"; ");
    }
}
void PrintArray(int[,] array)
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
Console.WriteLine("enter the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(columns, rows);
PrintArray(array);
Console.WriteLine("The arithmetic mean of each number: ");
ArithmeticMean(array);