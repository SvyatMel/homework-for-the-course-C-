/*Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/ 
// Без Метода
int OneNum (int numThree)
{
    if(numThree<100)
    {
        return numThree;
    }
    else
    {
        while(numThree>1000)
        {
            numThree=numThree /10;
        }
        return numThree %10 ;
    }
}
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num3=OneNum(number);
if(number==OneNum(number))
{
     Console.WriteLine("-> третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра заданного числа "+ num3);
}