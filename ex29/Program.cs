// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());
int res = 1;
int start = 1; 
while (start <=N)
{
    res= res*start;
    start++;
    
}
Console.WriteLine(res);