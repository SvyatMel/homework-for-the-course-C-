// Задайте двумерный массив размером m*n,заполненый случайными вещественными числами
double[,] CreatRandom2dArray()
{
    Console.Write("Введите m(колличество строк): ");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n(колличество столбцов): ");
    int n=Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите наименьшее значение элемента: ");
    // double minValue=Convert.ToDouble(Console.ReadLine());
    // Console.Write("Введите наибольшее значение элемента: ");
    // double maxValue=Convert.ToDouble(Console.ReadLine());
    double[,] array=new double[m,n];
        for(int i=0;i<m;i++)
            for(int j=0;j<n;j++)
                array[i,j]=Convert.ToDouble(new Random().Next(-100,100))/10;
        return array;
} 
void Show2dArray(double[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray=CreatRandom2dArray();
Show2dArray(myArray);