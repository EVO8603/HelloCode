﻿// Найти кубы чисел от 1 до N
Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <=N; i++)
{
    Console.WriteLine($"куб числа {i} = {Math.Pow(i, 3)}"); // Math.Pow - работает с double (но тут и с int работает почему то)
}