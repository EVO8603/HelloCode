﻿// Найти сумму чисел от 1 до N
Console.WriteLine("Enter the number - ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum}");