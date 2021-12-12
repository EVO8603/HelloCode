// Подсчитать сумму цифр в числе
Console.WriteLine("Ведите число");

int figure = int.Parse(Console.ReadLine());
int res = 0;
int b=0;
while (figure>0)
{
    b= figure % 10;
    res = res+b; 
    figure= figure/10;
}
Console.WriteLine(res);