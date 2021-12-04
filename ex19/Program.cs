// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("input x and y");

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x > 0 & y > 0)
{
Console.WriteLine("first quarter");
}
else if (x < 0 & y > 0 )
{
Console.WriteLine("second quarter");
}
else if (x<0 & y<0)
{
Console.WriteLine("third quarter");
}
else if (x>0 & y <0)
{
Console.WriteLine("fourth quarter");
}
else 
{
Console.WriteLine("can't define quarter");
}