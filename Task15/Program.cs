bool DayOff(int num)
{
    if(num <= 5)
    {
        return false;
    }
    else
    {
            return true;
    }
}
Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>7)
{
    Console.WriteLine("Введите число от 1 до 7!!!");
}
else
{
    bool examination = DayOff(number);
    if (examination == false)
    {
        Console.WriteLine("Данный день недели - рабочий");
    }
    else
    {
        Console.WriteLine("Данный день недели - выходной");
    }
}    