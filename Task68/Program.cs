// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Enter the number M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number N");
int n = Convert.ToInt32(Console.ReadLine());
int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);    
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m, n);
}
Console.WriteLine("Ackerman Function for numbers A("+m+","+n+") = "+AckermanFunction(m, n));