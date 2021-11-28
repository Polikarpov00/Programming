// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите 3х значное число ");

int n = int.Parse(Console.ReadLine());


if (n<=999 & n>=100)
{

int first = n / 100; //находим первую цифру 3х значного числа
int last = n % 10; // находим третью цифру 3х значного числа
int fin = first*10 + last; // 1 2 3  >>>  1*10 = 10 >>>  10 + 3 = 13
Console.WriteLine(fin);
}
else {
    Console.WriteLine("your number is wrong");
}
