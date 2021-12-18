// Выяснить являются ли три числа сторонами треугольника

double a = 7;  //new Random().Next(0,10);
double b = 10;  //new Random().Next(0,10);
double c = 12; //new Random().Next(0,10);

if (a+b>c & a+c>b & b+c >a)
{
    Console.WriteLine("Три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Три числа НЕ являются сторонами треугольника");
}
