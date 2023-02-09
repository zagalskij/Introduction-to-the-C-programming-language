// //  Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
Console.Write("Ввести размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести размер n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] FillArray(int m, int n)
{
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = arr[i, j] = new Random().Next(-9, 10);
    }
}
return arr;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}
int[,] FindPositionSmallElement(int[,] array)
{
  int temp = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = array[i, j];
      }
    }
