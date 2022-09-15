/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
------------------------------------------------------------------------
*/

// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1,n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) 
//         return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }
/*
----------------------------------------------------------------------------
*/

// int NumbersToN(int number1, int number2)
// {
    
//     if(number1>number2) return number2;
    
//     else
//     {
//         Console.Write(number1+ ", ");
//         number1++;
    
//     }
    
//     return NumbersToN(number1++, number2);

// }

// Console.WriteLine("Enter N: ");
// int numStart = 1;
// int numFinish = Convert.ToInt32(Console.ReadLine());

// NumbersToN(numStart,numFinish);


/*
-------------------------------------------------------------------------------------------
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5" M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

// int NumbersToN(int number1, int number2)
// {
// 	if (number1 > number2) return number2;
// 	else
// 	{
// 		Console.Write(number1 + ", ");
// 		number1++;
// 	}
// 	return NumbersToN(number1++, number2);
// }

// Console.WriteLine("Enter N: ");
// int numFinish = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter M: ");
// int numStart = Convert.ToInt32(Console.ReadLine());


// NumbersToN(numStart, numFinish);


/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SummNum(string num)
{
	int summ = 0;
	for(int i = 0; i < num.Length; i++){
		int n = Convert.ToInt32(num[i].ToString());
		summ += n;
	}
	return summ;
}

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine(SummNum(num));
