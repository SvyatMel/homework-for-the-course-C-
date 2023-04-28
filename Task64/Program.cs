// Задайте значение N.Напишите программу , которая выведет все натуральные числа в диапозоне от N до 1
void CreadNum(int num)
{
    Console.Write(num + " ");
    if(num>1) CreadNum(num-1);  
}
Console.Write("Введите число N: ");
int num=Convert.ToInt32(Console.ReadLine());
CreadNum(num);