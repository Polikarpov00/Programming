// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("введите X и Y ");
int X,Y;

X = int.Parse(Console.ReadLine());
Y = int.Parse(Console.ReadLine());

if ((X == 0 | X == 1) & (Y == 0 | Y== 1))
{
    if ((-(X |Y)) == (-X & -Y)) 
    {
        Console.WriteLine("утверждение верно");
    }
    else 
    {
        Console.WriteLine("неверное утверждение");  
    }

}
else 
{
    Console.WriteLine("неверные значения");
}


