// Выяснить, кратно ли число заданному, если нет, вывести остаток.


Console.Write("input number ");

int N = int.Parse(Console.ReadLine());
int n = 5;
int ost = N % n;
if (ost == 0)
{
    Console.WriteLine("кратно");
}


else 
{
    Console.WriteLine($"остаток равен = {ost}");
}





