int Num(int num1, int num2 )
{
    int total=1;
    for(int i=0; i<=num2; i++ )
    {
        total=total *num1 ;
    }
    return total;
}
  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int total = Num(numberA, numberB);
  Console.WriteLine("Ответ: " + total);