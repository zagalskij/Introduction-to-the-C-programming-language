// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool palindrom(int number)
{
    string str = Convert.ToString(number);
    int digitLast=str.Length-1;
    int digitCount=str.Length/2;
    int count=0;
    if(str.Length==1)
    return true;
    if(str[0]==str[digitLast]){
    for (int i = 1; i < digitCount; i++)
    {
         if(str[i]==str[digitLast-i])
         count++;
         else
         break;
    }
    if (count==digitCount-1)
    return true;
    else
    return false;}
    return false;
}
Console.WriteLine("enter a number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("the number "+num+" is a palindrome: "+palindrom(num));