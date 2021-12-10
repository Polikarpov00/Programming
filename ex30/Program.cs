// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("введите число");

double N = double.Parse(Console.ReadLine());

N = Math.Pow(N, 3);

if (N%2==0)
{
    Console.WriteLine($"последняя цифpа числа {N} чётная");
}
else 
{
    Console.WriteLine($"последняя цифpа числа {N} НЕ чётная");
}