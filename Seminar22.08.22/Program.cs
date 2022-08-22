using System.Security.Cryptography;
using System;
Random rand = new Random();
//Создаем переменную для рандома
int num = rand.Next(10,100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine(max);
//Оператор "И" &&
//Оператор "ИЛИ" ||
//Оператор "Не" !
