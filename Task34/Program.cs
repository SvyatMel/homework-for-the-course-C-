// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве
int[] Array(int size,int minValue,int MaxValue)
{
    int[] array = new int[size];
    for(int i = 0;i<size;i++)
        array[i]= new Random().Next(minValue,MaxValue+1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
}
int Quantity(int[] array)
{
    int total=0;
    for(int i=0;i<array.Length;i++)
        if(array[i] % 2 == 0) total++;
    return total;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение числа: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = Array(size,min,max);
ShowArray(newArray);
int total = Quantity(newArray);
Console.Write("Колличество четных элементов массива: " + total);