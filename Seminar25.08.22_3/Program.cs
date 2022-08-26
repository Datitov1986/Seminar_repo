/*
2 Задание: 
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/
using System;

void FindDistance(int X1, int Y1, int X2, int Y2)
{
    int DeltaX = (X2 - X1);
    int DeltaY = (Y2 - Y1);
    int stepen = 2;
    int x = Convert.ToInt32(Math.Pow(DeltaX, stepen));
    int y = Convert.ToInt32(Math.Pow(DeltaY, stepen));
    double result = Math.Sqrt (x + y);
    Console.WriteLine("Дистанция между точками = " + result);
}
Console.Write("ВВедите координату X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату X1: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату Y1: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки А: (" + X1 + ";" + Y1 + ")");
Console.WriteLine("Координаты точки B: (" + X2 + ";" + Y2 + ")");

FindDistance(X1, Y1, X2, Y2);


