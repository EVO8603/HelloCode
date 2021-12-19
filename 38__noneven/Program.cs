// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Enter the numbers");
int[] array = new int[8];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{


    array[i] = int.Parse(Console.ReadLine()); ;
    sum = sum + array[i];
    i++;

}
Console.WriteLine(sum);