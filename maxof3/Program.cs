//Найти максимальное из трех чисел
Console.WriteLine("Введите 3 числа:");

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numC = int.Parse(Console.ReadLine());

if (numA > numB)
 {
    if (numA>numC)
    {
        Console.Write("max is ");
        Console.WriteLine(numA);
    }
    else {
        Console.Write("max is ");
        Console.WriteLine(numC);
    }
}

else 
 {
 if (numB >numC)
    {
        Console.Write("max is ");
        Console.WriteLine(numB);
    }
    else {
        Console.Write("max is ");
        Console.WriteLine(numC);
    }
}
