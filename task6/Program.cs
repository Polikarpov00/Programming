// Выяснить является ли число чётным
Console.WriteLine("Input number");


int numA = int.Parse(Console.ReadLine());

if (numA % 2 ==0)                // % - проверка на чётность (деление без остатка)
{
    Console.WriteLine("number is even");
}
else 
{
    Console.WriteLine("number is not even");
}