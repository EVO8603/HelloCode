//  Показывает вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Показывает последнюю цифру трехзначного числа");
Console.WriteLine("Введите трёхзначное число - ");
int N = int.Parse(Console.ReadLine());

if ((N % 1000 >= 100 || N % 1000 <= -100) && N / 1000 == 0)
{
    Console.WriteLine($"Второй символ числа {N} равен: {(N % 100) /10}");   
}else
{
    Console.WriteLine($"Вы ввели некорректное число: {N}");
}
