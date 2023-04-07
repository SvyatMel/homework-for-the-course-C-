//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int Sum(int num)
{
    int total = 0;
    int variable = 0;
    for(int i = 0; i < num; i++)
    {
        variable = num - num%10;
        total = total + (num - variable);
        num /= 10;
    }
    return total;
}
Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
int sum=Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");