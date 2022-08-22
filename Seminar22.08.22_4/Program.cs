using System.Data;
using System;

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}