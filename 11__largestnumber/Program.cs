//  Показывает наибольшую цифру числа
Console.Clear();
Console.WriteLine("Показывает наибольшее число");
Console.WriteLine("Введите  число - ");
int N = Convert.ToInt32 (Console.ReadLine());

if (N % 10 >  N / 10)
{
    Console.WriteLine($"Наибольшая цифра числа {N} равна {N % 10}");   
}else
{
    Console.WriteLine($"Наибольшая цифра числа {N} равна {N / 10}");
}