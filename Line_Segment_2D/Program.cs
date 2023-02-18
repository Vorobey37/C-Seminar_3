/*
Напишите программу, которая на вход принимает координату отрезка в 2D пространстве (Xa, Ya, Xb, Yb),
а на выходе пишет длину этого отрезка.
*/
Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("Введите X");
double Xa = double.Parse(Console.ReadLine ());
Console.WriteLine("Введите Y");
double Ya = double.Parse(Console.ReadLine ());
Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("Введите X");
double Xb = double.Parse(Console.ReadLine ());
Console.WriteLine("Введите Y");
double Yb = double.Parse(Console.ReadLine ());

double L = Math.Sqrt(Math.Pow(Xb-Xa, 2) + Math.Pow(Yb-Ya, 2));
Console.WriteLine($"Длина отрезка будет {L}");

