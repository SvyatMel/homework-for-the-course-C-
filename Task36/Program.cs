//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int[size];
    for(int i=0;i<size;i++)
    array[i]= new Random().Next(minValue,maxValue+1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
int Sum(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i+=2)
    sum+=array[i];
    return sum;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray=CreateRandomArray(size,min,max);
ShowArray(newArray);
int totalSum=Sum(newArray);
Console.Write("Сумма всех элементов стоящих на нечетной позиции = " + totalSum);

