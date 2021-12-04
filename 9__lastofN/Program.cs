//  Показывает последнюю цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Показывает последнюю цифру трехзначного числа");
Console.WriteLine("Введите трёхзначное число - ");
int N = int.Parse(Console.ReadLine());

int NN = N % 10;
Console.WriteLine(NN);
