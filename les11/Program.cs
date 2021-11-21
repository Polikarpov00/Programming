//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("введите число A:");

int numA = int.Parse(Console.ReadLine());

Console.Write("введите число B:");

int numB = int.Parse(Console.ReadLine());

{
if (numA > numB)
{
    Console.Write(numA);
    Console.WriteLine(" большее число");
}

else 
{
    Console.Write(numA);
    Console.WriteLine(" меньшее число");
}

if (numB > numA)
{
    Console.Write(numB);
    Console.WriteLine(" большее число");
}

else 
{
    Console.Write(numB);
    Console.WriteLine(" меньшее число число");
    }
}
