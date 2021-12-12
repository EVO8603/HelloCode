// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("введите число");

double N = double.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine($"последняя цифpа числа {N} чётная, результат - {Math.Pow(N, 3)}");
}
else
{
    Console.WriteLine($"последняя цифpа числа {N} НЕ чётная");
}