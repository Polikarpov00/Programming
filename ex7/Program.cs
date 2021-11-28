// Показать числа от -N до N

/*
коментит все строки
1
2
3
4
5
*/
Console.Write("input N ");

int N = int.Parse(Console.ReadLine());
int min = -N;
while (min<=N) 
{
    Console.WriteLine(min);
    min = min+1; 
    

}

