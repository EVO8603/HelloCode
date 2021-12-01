//Является ли число чётным?
Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
//bool parity(double num) //показывает истина или ложь
if (num % 2 == 0)
Console.WriteLine("Это четное число");
else
Console.WriteLine("Число нечетное");
