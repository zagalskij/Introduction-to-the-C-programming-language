// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumRec(int initialValue, int finalValue)
{
    if (initialValue > finalValue) return 0;
    else return initialValue + SumRec(initialValue + 1, finalValue);
}
Console.WriteLine("Enter the initial value");
int initialValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the final value");
int finalValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of the elements in the range from "
+initialValue
+" to "
+finalValue
+ " "
+SumRec(initialValue, finalValue));