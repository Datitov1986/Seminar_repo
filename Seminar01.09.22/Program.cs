//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = {-4, 2, -5, 10, 2};
// int[] array1 = new int[5];

// for(int index = 0; index < array.Length; index++)
// {
//     array1[index] = array[index] * -1;
    
//     // int b = -1;
//     // int a = array[index];
//     // int temp = a * b;
// }
// Console.Write(string.Join(", ", array1));



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



// string FillArray(string[] numbers, string Value)
//  {
    
//     for(int index = 0; index < numbers.Length; index++)
//     {
//         numbers[index] = new Random().Next(1,10).ToString();
//         Console.Write(numbers[index] + ", ");
//      //return string.Join(", ", numbers);
//         if(numbers[index] == Value)
//         return "Да";
    
//     }
//     return "Нет";
//  }

// string[] array = new string[5];
// string Value = Console.ReadLine();
// Console.WriteLine(FillArray(array, Value));

// Console.WriteLine("Введите число:");
// int numb = Convert.ToInt32(Console.ReadLine());
// int [] array = {1,2,3,4,5,3,6};
// int size =array.Length;
// for(int a = 0;a<size;a++)
// if (numb==array[a])
// {
//     Console.WriteLine("Это число есть ");
// }
// else
// {
//     Console.WriteLine("Это числа нет");
// }

//1) использовать динамические массивы и задавать ему размер внутри программы
// int[] array = new int[a];

// void FillArray(int[] numbers)
//  {
    
//     for(int index = 0; index < numbers.Length; index++)
//     {
//         numbers[index] = new Random().Next(1,10).ToString();
//         Console.Write(numbers[index] + ", ");
//     }
//  }

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/



// int[] FillArray(int[] numbers)
//  {
    
//     for(int index = 0; index < numbers.Length; index++)
//     {
//         numbers[index] = new Random().Next(1,200);
//         Console.Write(numbers[index] + ", ");          
//     }
//     return numbers;
//  }

//  int Find(int[] numbers)
//  {
//     int count = 0;
//     foreach(int index in numbers)
//     {
//            if(index >= 10 && index <= 99)
//         {
//             count++;
//         }            
//     }    
//     return count;
//  }

// int[] array = new int[123];
// int[] abs = FillArray(array);
// Console.WriteLine();
// Console.WriteLine(Find(abs));

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// int[] FillArray(int[] numbers)
//  {
    
//     for(int index = 0; index < numbers.Length; index++)
//     {
//         numbers[index] = new Random().Next(1,10);
//         Console.Write(numbers[index] + ", ");          
//     }
//     return numbers;
//  }

// int[] Mult(int[] array)
// {
//     int size = array.Length;
//     for()
// }

// int[] array = new int[5];

int[] array4 = new int[6];
int[] array5 = new int[array4.Length / 2];

for (int i = 0; i < array4.Length; i++)
{
    int number = new Random().Next(0, 10);
    array4[i] = number;
    Console.Write(array4[i] + ", ");
}

//int multiply = 1;

for (int i = 0, j = array4.Length - 1; i < array4.Length / 2; i++, j--)
{
    array5[i] = array4[i] * array4[j];

}
Console.WriteLine("[{0}]", string.Join(", ", array5));