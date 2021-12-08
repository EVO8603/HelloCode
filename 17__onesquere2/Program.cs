// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool X,Y;

X = 0;
Y= 0;

if ((X == 0 | X == 1) & (Y == 0 | Y== 1))
{
    if ((-(X |Y)) == (-X & -Y)) 
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