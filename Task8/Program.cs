// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int[] array(int n)
{
    int[] mas = new int[n];
    mas[0]=1;
    int index=1;
    while (index<n){
    mas[index]=mas[index-1]+1;
    index++;}
    return mas;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int index=0;
    while(index<count)
    {
        Console.Write(col[index]+" ");
        index++;
    }
}
int[] chet(int[] array)
{
int[] mas = new int[array.Length/2];
int index=0;
int j=0;
while (index<array.Length){
 if (array[index]%2==0)
 {
mas[j]=array[index];
j++;}
index++;
}
return mas;}
Console.Write("Введите число: ");
PrintArray(chet(array(int.Parse(Console.ReadLine()))));


