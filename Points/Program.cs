/*
Напишите программу, которая на вход будет принимать номер четверти,
а на выход показывать диапазон возможных координат точек в этой четверти (X и Y)
*/
Console.Clear();
Console.WriteLine("Введите номер четверти:");
int a = int.Parse(Console.ReadLine());
while (a<1 || a>4)
{
    Console.WriteLine("Сам-то как думаешь, какие четверти бывают???");
    Console.WriteLine("Введите номер четверти:");
    a = int.Parse(Console.ReadLine());
}
switch (a)
    {
        case 1:
            {Console.WriteLine("X>0, Y>0");}
            break;
        case 2:
            {Console.WriteLine("X<0, Y>0");}
            break;
        case 3:
            {Console.WriteLine("X<0, Y<0");}
            break;
        case 4:
            {Console.WriteLine("X>0, Y<0");}
            break;
    }
