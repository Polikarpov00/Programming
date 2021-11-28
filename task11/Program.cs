// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = new Random().Next(10, 99);
Console.WriteLine($"random number - {num}"); // $ - выводит текст и {переменну}
int num1 = num / 10;
int num2 = num % 10;

if (num1 > num2)
{
    Console.WriteLine($"max num - {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"max num - {num2}");
}
else 
{
    Console.WriteLine("both numbers is equil");
    
}