// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("input number for dividing");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("input number ");
int n = int.Parse(Console.ReadLine());

int ost = N % n;
if (ost == 0)
{
    Console.WriteLine("кратно");
}

else 
{
    Console.WriteLine($"остаток равен = {ost}");
}