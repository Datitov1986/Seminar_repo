using System.Dynamic;
using System;

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = b % a;
if(result == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Не кратно, остаток: " + result);
}