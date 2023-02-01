// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите 
// в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
double[] CreateArray(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = double.Parse(Console.ReadLine());
    }
    return mas;
}
double[] SumsOfPairs(double[] array)
{

    double[] mas = new double[Convert.ToInt32(Math.Ceiling(array.Length / 2.0))];
    for (int i = 0; i < Math.Ceiling(array.Length / 2.0); i++)
    {
        if (i == array.Length - 1 - i)
        {
            mas[i] = array[i];
            return mas;
        }
        mas[i] = array[array.Length - 1 - i] * array[i];

    }
    return mas;
}
Console.WriteLine("Enter the length of the array");
double[] mas = CreateArray(int.Parse(Console.ReadLine()));
Console.Write("[");
Console.Write(string.Join(", ", mas));
Console.Write("] -> ");
Console.WriteLine(string.Join(" ", SumsOfPairs(mas)));
