// Задайте значение M и N. Напишите программу, которая найдет сумму натуральных
//элементов в промежутке от M до N.
int Sum(int m, int n)
{
if (m==n)
return n;
else return m + Sum(m + 1, n);
}
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:  ");
int n = Convert.ToInt32(Console.ReadLine());
int total=Sum(m,n);
Console.Write($"Сумма натуральных элементов в промежутке от M до N = {total}");

