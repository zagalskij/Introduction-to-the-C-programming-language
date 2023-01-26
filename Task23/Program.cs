double[] TableOfCubes(double number)
{
    double[] result = new double[Convert.ToInt32(number)];
    result[0] = 1;

    for (int i = 1; i < number; i++)

        result[i] = Math.Pow(i+1, 3);


    return result;
}
void PrintArray(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write(mas[i] + " ");
}
Console.WriteLine("Enter a number");

PrintArray(TableOfCubes(Convert.ToDouble(Console.ReadLine())));