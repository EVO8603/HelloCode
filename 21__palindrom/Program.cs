// Программа проверяет пятизначное число на палиндром
Console.WriteLine("input 5 figure ");

int figer5 = int.Parse(Console.ReadLine());

if (figer5 < 99999 & figer5 >= 10000 )
{
    int xx = figer5 /1000;  
    int num1 = xx / 10;
    int num2 = xx % 10;
    int yy = figer5 % 100;
    int num4 = yy / 10;
    int num5 = yy % 10;
    
    if ((num1 == num5) & (num2 == num4))
    {
        Console.WriteLine("this num is palindrom");
    }

    else 
    {
    Console.WriteLine(" num is NOT palindrom");
    }

}
else
{
   Console.WriteLine("wrong num"); 
}
