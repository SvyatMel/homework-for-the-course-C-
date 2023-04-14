// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] Array(int size)
{
    int[] array=new int[size];
    for(int i=0;i<size;i++)
    {
        Console.Write($"Введите число под индексом {i} :");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
int Total(int[] array)
{
    int quantity=0;
    for(int i=0;i<array.Length;i++)
    if(array[i]<0) quantity++;
    return quantity;
}
Console.Write("Введите длину массива: ");
int length=Convert.ToInt32(Console.ReadLine());
int[] num=Array(length);
ShowArray(num);
int total=Total(num);
Console.WriteLine($"В заданном массиве {total} отрицательных числа");