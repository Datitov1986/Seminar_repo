﻿/*
2 Задание: 
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/
// using System;

// void FindDistance(int X1, int Y1, int X2, int Y2)
// {
//     int DeltaX = (X2 - X1);
//     int DeltaY = (Y2 - Y1);
//     int stepen = 2;
//     int x = Convert.ToInt32(Math.Pow(DeltaX, stepen));
//     int y = Convert.ToInt32(Math.Pow(DeltaY, stepen));
//     double result = Math.Sqrt (x + y);
//     Console.WriteLine("Дистанция между точками = " + result);
// }
// Console.Write("ВВедите координату X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВедите координату Y1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВедите координату X1: ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВедите координату Y1: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты точки А: (" + X1 + ";" + Y1 + ")");
// Console.WriteLine("Координаты точки B: (" + X2 + ";" + Y2 + ")");

// FindDistance(X1, Y1, X2, Y2);


// 3 задание 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// using System;

// void SquareTable(int N, int count)
// {
//     Console.Write("Таблица квадратов от 1 до " + N + ": ");
//     while(count <= N)
//     {
//         int square = count * count;
//         Console.Write(square + ", ");
//         count++;
//     }
    
// }
// Console.Write("Введите ваше число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// SquareTable(N, count);

// 4 задание А
// Найти сумму и произведение элементов одномерного числового массива.

// using System;

// void ArrayCreation(int[] numbers)
//  {
//     int length = numbers.Length;
//     int index = 0;
//     while(index < length)
//      {
//         numbers[index] = new Random().Next(1,10);
//         index++;
//      }

//  }
// void PrintArray(int[] num)
//  {
//     int count = num.Length;
//     int position = 0;
//     while(position < count)
//      {
//         Console.Write(num[position] + ", ");
//         position++;
//      }
//  }

// int ArraySum(int[] numbers)
//  {
//     int index = 0;
//     int len = numbers.Length;
//     int summ = 0;
//     while(index < len)
//      {
//         summ = summ + numbers[index];
//         index++;
//      }
//     return summ;
//  }

// int ArrayComposition(int[] numbers)
//  {
//     int index = 0;
//     int len = numbers.Length;
//     int comp = 1;
//     while(index < len)
//      {
//         comp = comp * numbers[index];
//         index++;
//      }
//     return comp;
//  }

// int[] array = new int[5];
// ArrayCreation(array);
// PrintArray(array);
// ArrayComposition(array);
// Console.WriteLine();

// int sum = ArraySum(array);
// int com = ArrayComposition(array);
// Console.WriteLine("Сумма всех элементов массива = " + sum);
// Console.WriteLine("Произведение всех элемнтов массива = " + com);

// 4 задание Б 

// Найти сумму и произведение 2 рандомизированных массива (все значения должны быть случайными) 
// Обязательное условие оба массива одинаковы по размеру иначе упадете в ошибку ))

using System;

void Array1Creation(int[] numbers)
 {
    int length = numbers.Length;
    int index = 0;
    while(index < length)
     {
        numbers[index] = new Random().Next(1,10);
        index++;
     }
 }

void Array2Creation(int[] numbers1)
 {
    int length = numbers1.Length;
    int index = 0;
    while(index < length)
     {
        numbers1[index] = new Random().Next(1,10);
        index++;
     }
 }

void PrintArray1(int[] num)
 {
    int count = num.Length;
    int position = 0;
    Console.Write("Array 1: ");
 
    while(position < count)
     {
        Console.Write(num[position] + ", ");
        position++;
     }
    Console.WriteLine();
 } 

void PrintArray2(int[] num1)
 {
    int count = num1.Length;
    int position = 0;
    Console.Write("Array 2: ");
    while(position < count)
     {
        Console.Write(num1[position] + ", ");
        position++;
     }
 }
int ArraySum1(int[] numbers)
 {
    int index = 0;
    int len = numbers.Length;
    int summ1 = 0;
    while(index < len)
     {
        summ1 = summ1 + numbers[index];
        index++;
     }
    return summ1;
 }

int ArraySum2(int[] numbers1)
 {
    int index = 0;
    int len = numbers1.Length;
    int summ2 = 0;
    while(index < len)
     {
        summ2 = summ2 + numbers1[index];
        index++;
     }
    return summ2;
 }

int ArrayComposition1(int[] numbers)
 {
    int index = 0;
    int len = numbers.Length;
    int comp = 1;
    while(index < len)
     {
        comp = comp * numbers[index];
        index++;
     }
    return comp;
 }

int ArrayComposition2(int[] numbers1)
 {
    int index = 0;
    int len = numbers1.Length;
    int comp1 = 1;
    while(index < len)
     {
        comp1 = comp1 * numbers1[index];
        index++;
     }
    return comp1;
 }


int[] array1 = new int[5];
int[] array2 = new int[5];
Array1Creation(array1);
Array2Creation(array2);
PrintArray1(array1);
PrintArray2(array2);
Console.WriteLine();

int sum1 = ArraySum1(array1);
int sum2 = ArraySum2(array2);
int AverageSum = sum1 + sum2;
int com = ArrayComposition1(array1);
int com1 = ArrayComposition2(array2);
int AverageComposition = com * com1;
Console.WriteLine("Сумма двух массивов = " + AverageSum);
Console.WriteLine("Произведение двух массивов = " + AverageComposition);



