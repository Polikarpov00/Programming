// Показать двумерный массив размером m×n заполненный целыми числами
int m = 3;
int n = 4;

int[,] array = new int[m,n]; // {{1,2,3,1},{4,3,2,8},{1,5,6,7}};
    
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j]);

        }
        Console.WriteLine();
    }
}
FillArray(array);
Print(array);
