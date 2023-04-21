// Задайте двумерный массив из целых чисел.Найдите среднее арифметическое каждого столбца
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
void Averages(int[,] array)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        double aver=0;
        int sum=0;
            for(int i=0;i<array.GetLength(0);i++)
            {
                sum=sum+array[i,j];
                aver=sum/array.GetLength(0);
            }
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {aver}");
    }    
}
int[,] myArray=CreatRandom2dArray();
Show2dArray(myArray);
Averages(myArray);