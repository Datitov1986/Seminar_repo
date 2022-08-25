Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка находится в " + ChetvertVPloskosti(x,y) + " четверти");

int ChetvertVPloskosti(int X, int Y)
{
    if(X > 0 && Y > 0)
        return 1;

    if(X < 0 && Y > 0)
        return 2;
    
    if(X < 0 && Y < 0)
        return 3;

    if(X > 0 && Y < 0)
        return 4;
    
    return 0;
}