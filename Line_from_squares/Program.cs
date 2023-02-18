/*
Напишите программу, которая принимает на вход целое цисло, а на выходе 
будет выводить квадрат всех чисел от 1 до N (если N положительное) 
или от -N до 1 (если N отрицательное или 0). 
*/
Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
int m = N;
int i = 1;
int a = N;

if (N<0)
{
    i = N;
    m = -N;
    N = -1;
}

int[] mass = new int [m];
int j = 0;

if (a==0)
{Console.Write($"0 1");}

for (; i<=N; i++)
    {
        mass[j] = i*i;
        j++;
    }
for (j=0; j<m; j++)
    {
        Console.Write($"{mass[j]} ");
    }
if (a<0)
{
    Console.Write($"0 1");
}
