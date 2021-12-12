// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());
int res = 1;
int i = 1;
while (i <= N)
{
    res = res * i;
    i++;

}
Console.WriteLine(res);