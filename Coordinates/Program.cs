/*Напишите программу, которая на вход принимает координаты точки (X и Y), 
причем X и Y не равны 0, и выдает номер четверти плоскости, 
в которой находятся эти точки.*/
Console.Clear();
Console.WriteLine("Введите значение X");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y");
int Y = int.Parse(Console.ReadLine());

while (X==0 && Y==0)
    {
        Console.WriteLine("Точка находится в центре");
        Console.WriteLine("Введите значение X");
        X = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение Y");
        Y = int.Parse(Console.ReadLine());
    }
while (X==0 || Y==0)
    {
        Console.WriteLine("Точка находится на оси");
        Console.WriteLine("Введите значение X");
        X = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение Y");
        Y = int.Parse(Console.ReadLine());
    }
if (X>0 && Y>0)
    {
        Console.WriteLine("Точка находится в I четверти");
    }
else if (X<0 && Y>0)
    {
        Console.WriteLine("Точка находится во II четверти");
    }
else if (X<0 && Y<0)
    {
        Console.WriteLine("Точка находится в III четверти");
    }
else if (X>0 && Y<0)
    {
        Console.WriteLine("Точка находится в IV четверти");
    }

