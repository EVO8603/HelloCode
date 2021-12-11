//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("input x&y");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x > 0 & y > 0)
{
    Console.WriteLine("first quater");
}
else if (x < 0 & y > 0)
    {
        Console.WriteLine("second quater");
    }
else if (x < 0 & y < 0)
    {
        Console.WriteLine("third quater");
    }
else
{
    Console.WriteLine("fourth quater");
}