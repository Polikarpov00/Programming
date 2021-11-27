// По заданному номеру дня недели вывести его название

//                0    1      2      3      4       5     6      7
string[] week = {"", "mon", "tue", "wed", "thu", "fri", "sat", "sun" };

Console.Write("введите номер дня недели "); 

int day = int.Parse(Console.ReadLine());

//Console.Write(String.Join(" ",week.Skip(day).First()));   // .Skip(day) - пропускаем элементы массива до введённого нами индекса. 
                                                            //.First() - останавливаемся на первом значении.
                                                             // String.Join - Сцепляет элементы указанного массива или элементы коллекция, помещая между ними заданный разделитель



Console.WriteLine(week[day]);