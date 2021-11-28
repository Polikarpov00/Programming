// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
//                0     1      2      3      4      5      6      7
string[] week = {" ", "mon", "tue", "wed", "thu", "fri", "sat", "sun" };

Console.Write("введите номер дня недели "); 

int a = week.Length;
int day = int.Parse(Console.ReadLine());

while (day <= a-2)
{
     Console.WriteLine(" weekDAY:| ");
     break;
}
  
  if (day >= a-2)
  {
    Console.WriteLine(" weekEND!:))))))) ");
  }

