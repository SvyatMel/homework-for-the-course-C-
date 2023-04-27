// Задайте две матрицы.Напишите программу ,которая будет находить их произведение.
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
int[,] ResultArray(int[,] oneArray,int[,] twoArray)
{
    int[,] newArray= new int[oneArray.GetLength(0),twoArray.GetLength(1)];
    for(int i=0;i<oneArray.GetLength(0);i++)
    {
        for(int j=0;j<oneArray.GetLength(1);j++)
        {
            newArray[i,j]=0;
            for(int k=0;k<twoArray.GetLength(0);k++)
            {
                newArray[i,j]+=oneArray[i,k]*twoArray[k,j];
            }
        }
    }
    return newArray;
}
int[,] oneMat=CreatRandom2dArray();
Show2dArray(oneMat);
int[,] twoMat=CreatRandom2dArray();
Show2dArray(twoMat);
int[,] total=ResultArray(oneMat,twoMat);
Show2dArray(total);
