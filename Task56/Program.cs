//Задайте прямоугольный двумерный массив .Напишите программу ,которая
//будет находить строку с наименьшей суммой элементов .
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
int Sum(int[,] array, int i)
{
    int sum=array[i,0];
        for(int j=1;j<array.GetLength(1);j++) sum+=array[i,j];
    return sum;
}
int[,] myArray=CreatRandom2dArray();
Show2dArray(myArray);
int min=1;
int sum=Sum(myArray,0);
for(int i=1;i<myArray.GetLength(0);i++)
{
    if(sum>Sum(myArray,i)) min=i+1;
}
Console.WriteLine($"Строка с наименьшей суммой всех элементов {min}");
