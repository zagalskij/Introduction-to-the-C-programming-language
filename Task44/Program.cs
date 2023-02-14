// Не используя рекурсию, выведите первые N чисел Фибоначи.
// Первые два числа Фибоначи: 0 и 1.
// Если N=5 -> 0 1 1 2 3
// Если N=3 -> 0 1 1 
// Если N=7 -> 0 1 1 2 3 5 8
int[] Fibonacсi(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.WriteLine("Enter the number of elements in the array");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Если N=" + number + " -> " + string.Join(" ", Fibonacсi(number)));