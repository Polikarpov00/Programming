// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Hello, your massive is");

int[] array = new int[5];
int len= array.Length;
int count = 0;
int countEven = 0;

for (int i = 0; i <len ; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}
for (int i =0; i < len; i++)
{
    if (array[i]%2==0)
    {
        countEven++;
    }
    else
    {
        count++;
    }
}
Console.WriteLine($"чётныx {countEven}, нечётных {count}");