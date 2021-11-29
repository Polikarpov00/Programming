// По двум заданным числам проверять является ли одно квадратом другого


Console.WriteLine("Введите два числа ");

int a,b;

 a = int.Parse(Console.ReadLine()); 
 b = int.Parse(Console.ReadLine());

if (a / b == b & a % b ==0)
{
    Console.WriteLine($"число {a} является квадратом числа {b} ");
}
else if (b / a == a & b % a ==0)
{
     Console.WriteLine($"число {b} является квадратом числа {a} ");
}
else 
{
     Console.WriteLine($"ни одно число не является квадратом другого");
}


