// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("input number");

int a = int.Parse(Console.ReadLine());
int div7 = a % 7;
int div23 = a % 23;

if (div7==0 & div23==0 )
{
    Console.WriteLine("number is divisible by 7 and 23");
}
else 
{
    Console.WriteLine("number is NOT divisible by 7 and 23");
}





