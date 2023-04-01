void Cubed(int num)
{
    for(int i = 1 ;i <= num;i++)
    {
        int y=3;
        Console.WriteLine(Math.Pow(i,y));
    }
}
Console.Write("Введите число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Cubed(num1);
