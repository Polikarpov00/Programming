﻿// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите 3х значное число ");

int n = int.Parse(Console.ReadLine());

if (n<=999 & n>=100)
{

int last = n % 100;
last = last/10;
Console.WriteLine(last);
}
else {
    Console.WriteLine("your number is wrong");
}