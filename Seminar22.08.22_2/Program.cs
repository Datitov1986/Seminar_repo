
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

using System;
Random rnd = new Random();
int num = rnd.Next(100,1000);
Console.WriteLine(num);
int x = num / 100;
x = x*10;
x = x + (x%10);
int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"its -> {x}");

