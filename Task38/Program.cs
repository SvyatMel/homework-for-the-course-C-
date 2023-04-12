// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int[size];
    for(int i=0;i<size;i++)
    array[i]=new Random().Next(minValue,maxValue+1);
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
    int total=0;
    int maxNum=array[0];
    int minNum=array[0];
    for(int i = 0;i<array.Length;i++)
        if(array[i]>maxNum) maxNum=array[i];
    for(int j = 0;j<array.Length;j++)
        if(array[j]<minNum) minNum=array[j];
    total=maxNum-minNum;
    return total;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray=CreateRandomArray(size,min,max);
ShowArray(newArray);
int diff=Total(newArray);
Console.WriteLine("Разница между максимальным и минимальм элементом = " + diff);