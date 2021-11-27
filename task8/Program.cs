// Показать четные числа от 1 до N

Console.Write("input your number ");
int N = int.Parse(Console.ReadLine());


int start = 1;
int next = start+1;

while (next<=N)
{
    if (next % 2 == 0)
    {
        Console.WriteLine(next);
        
    }
    next = next+2;
}

