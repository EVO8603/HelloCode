﻿//Показать чётные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите число N:");
double N = Convert.ToInt32 (Console.ReadLine());
for (int i = 1; i <= N; i++)
    if (i % 2 == 0) Console.Write($" {i} ");
