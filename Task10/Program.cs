int CutNumber(int num)
{
    int hunders = num % 100;
    int units = num % 10;
    int result = (hunders - units)/10;
    return result;
}
Console.WriteLine("Введите трехзначное число");
int numOne= Convert.ToInt32(Console.ReadLine());
int newNumber=CutNumber(numOne);
Console.WriteLine("Вторая цифра числа");
Console.WriteLine(newNumber);