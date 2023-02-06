// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
// массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
int Sum (int[,] arr)
{
    int result =0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i==j)
            result+=arr[i,j];
        }
}
return result;
}
int[,] arr = FillArray(m,n);
PrintArr(arr);
Console.WriteLine("The sum of the array elements diagonally:" +Sum(arr));