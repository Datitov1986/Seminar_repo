/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

// void FuelArray(int m, int n, int[,] array)
// {
// 	for(int i = 0; i<m; i++){
// 		for(int j = 0; j<n; j++){
// 			array[i,j] =j +i;
// 		}
// 	}

// 	for(int i = 0; i<array.GetLength(0); i++){
// 		for(int j = 0; j<array.GetLength(1); j++){
// 			Console.Write(array[i,j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }


// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[m, n];
// FuelArray(m, n, array);


/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// void FuelArray(int m, int n, int[,] array)
// {
// 	for (int i = 0; i < m; i++)
// 	{
// 		for (int j = 0; j < n; j++)
// 		{
// 			array[i, j] = new Random().Next(1, 10);
// 		}
// 	}

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine("----------------------------------------");
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if(i%2 == 0 && j%2 ==0)array[i,j] *= array[i,j];
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}

// }

// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// FuelArray(m, n, array);

/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

// void FuelArray(int m, int n, int[,] array)
// {
// 	int summ = 0;
// 	for (int i = 0; i < m; i++)
// 	{
// 		for (int j = 0; j < n; j++)
// 		{
// 			array[i, j] = new Random().Next(1, 10);
// 		}
// 	}
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if(i == j)summ += array[i,j];
// 		}
		
// 	}
// 	Console.WriteLine("Сумма равна: " + summ);
// }

// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// FuelArray(m, n, array);

/*Задача дополнительная 
Задайте двумерный массив. Найдите сумму элементов, находящихся ниже главной диагонали 

еще дополнитель 
Кто все сделал , попробуйте 
*/

// void FuelArray(int m, int n, int[,] array)
// {
// 	int summ = 0;
// 	for (int i = 0; i < m; i++)
// 	{
// 		for (int j = 0; j < n; j++)
// 		{
// 			array[i, j] = new Random().Next(1, 10);
// 		}
// 	}
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
//     for(int c = 1; c <= array.GetLength(0); c++)
//     {
//         for (int i = 0; i + c < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if(i == j)summ += array[i + c,j];
//             }
            
//         }
//     }
//     Console.WriteLine("Сумма равна: " + summ);
// }

// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// FuelArray(m, n, array);




/*Задача 51**: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив (за один цикл):
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

void FuelArray(int m, int n, int[,] array)
{
	int summ = 0;
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(1, 10);
		}
	}
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}

	for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
	{
		
	{
		if(i == j)summ += array[i,j];
	}
		
	}
	Console.WriteLine("Сумма равна: " + summ);
}

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FuelArray(m, n, array);