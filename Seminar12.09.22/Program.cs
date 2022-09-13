/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

// int[,] FillArray(int m, int n)
// {
// 	int[,] array = new int[m, n];
// 	for (int i = 0; i < m; i++)
// 	{
// 		for (int j = 0; j < n; j++)
// 		{
// 			array[i, j] = new Random().Next(0, 10);
// 		}
// 	}
// 	return array;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// int[,] ReversString(int[,] array)
// {
// 	int temp = 0;
// 	int i = 0;
// 	for (int j = 0; j < array.GetLength(1); j++)
// 	{
// 		temp = array[i,j];
// 		array[i,j] = array[array.GetLength(0)-1,j];
// 		array[array.GetLength(0)-1,j] = temp;
// 	}
// 	return array;
// }

// int[,] array = FillArray(5, 5);
// PrintArray(array);
// Console.WriteLine();
// PrintArray(ReversString(array));




/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

// int[,] FillArray(int m, int n)
// {
// 	int[,] array = new int[m, n];
// 	for (int i = 0; i < m; i++)
// 	{
// 		for (int j = 0; j < n; j++)
// 		{
// 			array[i, j] = new Random().Next(0, 10);
// 		}
// 	}
// 	return array;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// int[,] ReverseArray(int[,] array)
// {
// 	int row = array.GetLength(0);
// 	int columns = array.GetLength(1);
// 	int[,] numbers = new int[row, columns];
// 	for (int i = 0; i < columns; i++)
// 	{
// 		for (int j = 0; j < row; j++)
// 		{
// 			numbers[i,j] = array[j,i];
// 		}
// 	}

// 	return numbers;
// }

// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = FillArray(m, n);
// PrintArray(array);
// Console.WriteLine();
// if (m == n)
// {
// 	PrintArray(ReverseArray(array));
// }

// else Console.WriteLine("Некорректные данные");



/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример. Есть набор данных:
{ 1, 9, 9, 0, 2, 8, 0, 9 }


Частотный массив можно представить так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}


void FindNumbers(int[,] array)
{
	var element = new List<int>();
	var count = new List<int>();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (!element.Contains(array[i, j]))
			{
				element.Add(array[i, j]);
				count.Add(1);
			}
			else
			{
				for (int m = 0; m < element.Count; m++)
				{
					if (array[i, j] == element[m]) count[m] += 1;
				}
			}
		}
	}
	PrintList(element, count);
}

void PrintList(List<int> element, List<int> count)
{
	SortingList(element, count);

	for (int i = 0; i < element.Count; i++)
	{
		Console.WriteLine(element[i] + " встречается " + count[i] + " раз");
	}
}

void SortingList(List<int> element, List<int> count)
{
	int[] temp = new int[2];
	for (int i = 0; i < element.Count; i++)
	{
		for (int j = 0; j < element.Count - 1; j++)
		{
			if (element[j] > element[j + 1])
			{
				temp[0] = element[j];
				temp[1] = count[j];
				element[j] = element[j + 1];
				count[j] = count[j + 1];
				element[j + 1] = temp[0];
				count[j + 1] = temp[1];
			}
		}
	}
}


Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
FindNumbers(array);





/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
*/

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[] rowAr = GetRowArray(array);
// SortArray(rowAr);
// Console.WriteLine(String.Join(" ",rowAr));
// PrintData(rowAr);
 
// int[,] GetArray(int m, int n, int min, int max)
// {
//    int[,] result = new int[m, n];
//    for (int i = 0; i < m; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            result[i, j] = new Random().Next(min, max + 1);
//        }
 
//    }
//    return result;
// }
 
// int[] GetRowArray(int[,] inArray)
// {
//    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
//    int index=0;
//    for (int i = 0; i < inArray.GetLength(0); i++)
//    {
//        for (int j = 0; j < inArray.GetLength(1); j++)
//        {
//            result[index] = inArray[i,j];
//            index++;
//        }
//    }
//    return result;
// }
 
// void SortArray(int[] inArray)
// {
//    for (int i = 0; i < inArray.Length; i++)
//    {
//        for (int j = i+1; j < inArray.Length; j++)
//        {
//            if(inArray[i]>inArray[j])
//            {
//                int k=inArray[i];
//                inArray[i]=inArray[j];
//                inArray[j]=k;
//            }
//        }
//    }
// }
 
 
// void PrintArray(int[,] inArray)
// {
//    for (int i = 0; i < inArray.GetLength(0); i++)
//    {
//        for (int j = 0; j < inArray.GetLength(1); j++)
//        {
//            Console.Write($"{inArray[i, j]} ");
//        }
//        Console.WriteLine();
//    }
// }
 
// void PrintData(int[] inArray)
// {
//    int el=inArray[0];
//    int count = 1;
//    for (int i = 1; i < inArray.Length; i++)
//    {
//        if(inArray[i]!=el)
//        {
//            Console.WriteLine($"{el} встречается {count}");
//            el=inArray[i];
//            count=1;
//        }
//        else
//        {
//            count++;
//        }
//    }
//     Console.WriteLine($"{el} встречается {count}");

// }   