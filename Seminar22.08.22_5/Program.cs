
using System;

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 * number1 == number2)
{
    Console.WriteLine(number1 + " является квадратом числа" + number2);
}
else if(number2 * number2 == number1)
{
    Console.WriteLine(number2 + " является квадратом числа" + number1);
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}

