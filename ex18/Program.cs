// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//Console.WriteLine("введите X и Y ");
// int X,Y;

// X = int.Parse(Console.ReadLine());
// Y = int.Parse(Console.ReadLine());

// if ((X == 0 | X == 1) & (Y == 0 | Y== 1))
// {
//     if ((-(X |Y)) == (-X & -Y)) 
//     {
//         Console.WriteLine("утверждение верно");
//     }
//     else 
//     {
//         Console.WriteLine("неверное утверждение");  
//     }

// }
// else 
// {
//     Console.WriteLine("неверные значения");
// }

bool[] x = {false , true}; 
bool[] y = {false , true}; 

int lenx = x.Length; 
int leny = y.Length; 

int startx = 0;
int starty = 0;

while (lenx <= 1 & leny <= 1)
{
   
   if ((!(x[startx] |y[starty])) == (!x[startx] & !y[starty]))
    {
       Console.WriteLine("true"); 
       startx ++;
       starty ++;
    }
    else 
    {
        Console.WriteLine("false"); 
    }

}
    Console.WriteLine("false"); 

