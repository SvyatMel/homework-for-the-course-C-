// Напишите программу ,которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание ,что такого элемента нет
int[,] CreatRandom2dArray()
{
    Console.Write("Введите m(колличество строк): ");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n(колличество столбцов): ");
    int n=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue=Convert.ToInt32(Console.ReadLine());
    int[,] array=new int[m,n];
    for(int i=0;i<m;i++)
        for(int j=0;j<n;j++)
            array[i,j]=new Random().Next(minValue,maxValue);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] Transformation(int[,] array)
{
    int size=array.GetLength(0)*array.GetLength(1);
    int[] newArray=new int[size];
    int newIndex = 0;
    for(int i=0;i<array.GetLength(0);i++)
        for(int j=0;j<array.GetLength(1);j++)
            {
                newArray[newIndex]=array[i,j];
                newIndex++;
            }
    return newArray;
    

}
bool Checking(int index,int[] array)
{
    if(index<=array.Length) return true;
    else return false;
}
int Total(int index,int[] array)
{
    int total=0;
    for(int i=0;i<array.Length;i++)
        if(index==i) total=array[i];
    return total;
}
int[,] myArray=CreatRandom2dArray();
Show2dArray(myArray);
Console.Write("Введите индекс нужного элемента: ");
int index=Convert.ToInt32(Console.ReadLine());
int[] newArray=Transformation(myArray);
int num=0;
bool chec=Checking(index,newArray);
    if(chec==true)
    {
        num=Total(index,newArray);
        Console.WriteLine($"значение числа под индексом {index} = {num}");
    }
    else
    Console.WriteLine($"Числа под индексом {index} не существует");
