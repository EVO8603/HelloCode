// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("input number");
int a = int.Parse(Console.ReadLine());
if (a <= 999 & a >=100)
{
    a = a % 10;
    Console.WriteLine(a);
}

else if (a <= 99)
{
    Console.WriteLine("the third number is absent");
}
 else 
 { 
     while (a >999)
     {
         a = a/10;
     }
         a = a % 10;
        Console.WriteLine(a);
 }
