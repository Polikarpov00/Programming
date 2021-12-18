// Написать программу преобразования десятичного числа в двоичное

int a = 13;

void ToBin(int n)
{
    if(n==0)
    {
        return;
    }
    
    ToBin(n/2);
    Console.Write(n%2);
}
ToBin(a);
