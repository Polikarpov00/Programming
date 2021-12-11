// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("Hello, World!");

int[] array = new int[123];
int len = array.Length;
int count = 0;
for(int i = 0 ; i < len; i++)
{
    array[i] = new Random().Next(0,999);
    Console.Write($"{array[i]} ");
}
for(int i = 0 ; i < len; i++)
{
    if(array[i] >=10 & array[i] <=99 )
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"чисел входящих в отрезок (10,99) {count}");