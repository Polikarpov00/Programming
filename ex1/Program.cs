//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("введите число A:");

int numA = int.Parse(Console.ReadLine());

Console.Write("введите число B:");

int numB = int.Parse(Console.ReadLine());

int res = numA / numB; 

Console.WriteLine(res);

if (res == numB)
{
    Console.WriteLine("правильно");
}

else 
{
    Console.WriteLine("неправильно");
}
