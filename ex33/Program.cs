// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12]; 
int len = array.Length;
int index = 0;
int res = 0;
while(index < len)
{
    array[index] = new Random().Next(0,10);
    index++;
}
for (int i=0; i<len; i++)
{
    res = res+ array[i];
    Console.Write(array[i]);
}
Console.Write(" ");
Console.WriteLine($"сумма положительных = {res}, сумма отрицательных = {-res}");