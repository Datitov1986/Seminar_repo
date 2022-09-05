// int[] FillingArray(int lengthArray)
// {
//     System.Random numberGenerator = new System.Random();
//     int i = 0;
//     int[] outArray = new int[lengthArray];
//     while(i < lengthArray)
//     {
//         outArray[i] = numberGenerator.Next(1,100);
//         i++;
//     }
//     return outArray;
// }

// void Print1DArray(int[] inputArray)
// {
//     int i = 0;
//     while(i < inputArray.Length - 1)
//     {
//         Console.Write(inputArray[i] + ", ");
//         i++;
//     }
//     Console.WriteLine(inputArray[i]);
// }

// int[] ReversNewArray(int[] inputArray)
// {
//     int[] outArray = new int[inputArray.Length];
//     int i = 0;
//     while(i < inputArray.Length)
//     {
//         outArray[inputArray.Length - 1 - i] = inputArray[i];
//         i++;
//     }
//     return outArray;
// }

// int[] ReversSwapArray(int[] inputArray)
// {
//     int swapElement = 0;
//     for (int i = 0; i < inputArray.Length / 2; i++)
//     {
//         swapElement = inputArray[i];
//         inputArray[i] = inputArray[inputArray.Length - 1 -i];
//         inputArray[inputArray.Length - 1 -i] = swapElement;
//     }
//     return inputArray;
// }

// int[] array = FillingArray(15);
// Print1DArray(array);
// //int[] bufArray = ReversNewArray(array);
// Print1DArray(ReversNewArray(array));
// Print1DArray(ReversSwapArray(array));

//------------------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------------------
/* Задача 40. Напишите программу, которая принимает на вход три части и проверяет может ли существовать треугольник такой длинн*/

// int Read(string Line)
// {
//     Console.WriteLine(Line);
//     return int.Parse(Console.ReadLine()??"");
// }

// bool Test(int a, int b, int c)
// {
//     if ((a < b + c) && (b < a + c) && (c < a + b))
//         return true;
//     else
//         return false;
// }

// void Print(bool res)
// {
//     if(res)
//     Console.WriteLine("Можно составить треугольник! ");
//     else
//     Console.WriteLine("Нельзя составить треугольник! ");
// }

// int SideA = Read("Введите сторону А ");
// int SideB = Read("Введите сторону B ");
// int SideC = Read("Введите сторону C ");

// bool resultTest = Test(SideA, SideB, SideC);

// Print(resultTest);

//---------------------------------------------------------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------------------------------------
/* Задача Напишите программу, которая будет преобразовывать десятичные числа в двоичные*/


string UpdateToDouble(int num)
{
    string Binare = "";
    while(num > 0)
    {
        Binare += num % 2; 
        num = num / 2;  
        
    }
    return Binare;
}


Console.WriteLine(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(UpdateToDouble(num));
