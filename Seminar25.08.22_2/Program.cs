// Console.WriteLine("В какой четверти находится ваша точка?");
// int chetv = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Диапазон точек " + point(chetv));

// string point(int chetv)
// {
//     if(chetv == 1)
//         return "+et; +et";
//     if(chetv == 2)
//         return "-et; +et";
//     if(chetv == 3)
//         return "-et;-et";
//     if(chetv == 4)
//         return "+et;-et";
//     return "Нет такой четверти";
// }

//Вариант решения с функцией void

Console.WriteLine("В какой четверти находится ваша точка?");
int chetv = Convert.ToInt32(Console.ReadLine());
point(chetv);

int point(int chetv);
{
    if(chetv == 1)
        Console.WriteLine("+et;+et");
    if(chetv == 2)
        Console.WriteLine("-et;+et");
    if(chetv == 3)
        Console.WriteLine("-et;-et");
    if(chetv == 4)
        Console.WriteLine("+et;-et");
}