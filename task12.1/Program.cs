// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите 3х значное число ");

int n = int.Parse(Console.ReadLine());


if (n<=999 & n>=100)
{

int first = n / 100;
int last = n % 10;
int fin = first*10 + last;
Console.WriteLine(fin);
}
else {
    Console.WriteLine("your number is wrong");
}
