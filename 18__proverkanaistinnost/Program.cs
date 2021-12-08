// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("Enter 2 numbers");

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if ((x == 0 | x == 1) & (y == 0 | y == 1))
{
    if ((-(x | y)) == (-x & -y))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }

}
else
{
    Console.WriteLine("неверные значения");
}