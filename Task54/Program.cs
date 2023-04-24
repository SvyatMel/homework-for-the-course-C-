// Задайте двумерный массив.Напишите программу,которая упорядочит 
//по убываюнию элементы каждой строки двумерного массива.
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
int[,] New2dArray(int[,] array)
{
    for(int temp=0;temp<array.GetLength(0);temp++)
        {
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j=array.GetLength(1)-1;j>i;j--)
                {
                    if(array[temp,j]>array[temp,j-1])
                    {
                        int min=array[temp,j];
                        array[temp,j]=array[temp,j-1];
                        array[temp,j-1]=min;
                    }
                }
            }
        }
    return array;
}
int[,] myArray=CreatRandom2dArray();
Show2dArray(myArray);
int[,] newArray=New2dArray(myArray);
Show2dArray(newArray);