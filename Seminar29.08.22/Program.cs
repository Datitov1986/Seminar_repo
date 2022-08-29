//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Console.Write("Введите число: ");
// string num = (Console.ReadLine());
// Console.WriteLine(Kolichestvo(num));

// int Kolichestvo(string num)
// {
//     int length = num.Length;
//     return length;
// }

/*
2) Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120

*/

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Compilation(N));

// int Compilation(int N)
// {
//     int Comp = 1;
//     for(int index = 1; index <= N; index++)
//     {
//         Comp = Comp * index;
       
//     }
//     return Comp;
// }

/*
3)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// int[] array = new int[8];
// ArrayCreation(array);


// void ArrayCreation(int[] numbers)
//  {
//     for(int index = 0; index < numbers.Length; index++)
//      {
//         numbers[index] = new Random().Next(0,2); 
//         Console.Write(numbers[index] + ", ");
         
//      }
//  }

/*
4) Создайте массив А[7] с помощью генератора случайных чисел и выведите его на экран. Увеличьте все его элементы в 2 раза.
*/

// int size = 7;
// int[] array = new int[size];
// ArrayCreation(array);
// Console.WriteLine();
// X2(array);


// void ArrayCreation(int[] array)
//  {
//     for(int index = 0; index < array.Length; index++)
//      {
//         array[index] = new Random().Next(0,10); 
//         Console.Write(array[index] + ", ");
//      }
//  }

// void X2(int[] array)
// {   
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = array[index] * 2;
//         Console.Write(array[index] + ", ");
//     }
// }

/*
5) Создайте массив А[12] с помощью генератора случайных чисел с элементами от –20 до 10 и выведите его на экран. Замените все отрицательные элементы массива числом 0.
*/
// int size = 12;
// int[] array = new int[size];
// ArrayCreation(array);
// Console.WriteLine();
// Replace(array);

// void ArrayCreation(int[] array)
//  {
//     for(int index = 0; index < array.Length; index++)
//      {
//         array[index] = new Random().Next(-20,11); 
//         Console.Write(array[index] + ", ");
//      }
//  }

//  void Replace(int[] array)
//  {
//     for(int index = 0; index < array.Length; index++)
//     {
//         if(array[index] < 0)
//         {
//             array[index] = 0;
//             Console.Write(array[index] + ", ");
//         }
//         else
//             Console.Write(array[index] + ", ");
//     }
//  }


/*
6) Найти сумму всех элементов массива чисел, больших заданного числа. Размерность массива – 20. Заполнение массива осуществить случайными числами от 50 до 100
7)Найти минимальный и максимальный элемент массива заполненного случайными числами. Размер массива - 10ж
*/


