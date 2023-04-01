double Coor(double x,double y,double z)
{
    double coor1 = Math.Sqrt(x+y+z);
    double coor2=Math.Round(coor1,2);
    return coor2;

}
Console.WriteLine("Введите координаты точки 1");
Console.Write("Введите x1 = ");
int x1 =Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите y1 = ");
int y1 =Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите z1 = ");
int z1 =Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты точки 2");
Console.Write("Введите x2 = ");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2 = ");
int y2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2 = ");
int z2 =Convert.ToInt32(Console.ReadLine());
double X=Math.Pow(x2-x1,2);
double Y=Math.Pow(y2-y1,2);
double Z=Math.Pow(z2-z1,2);
double coordinates=Coor(X,Y,Z);
Console.WriteLine(coordinates);
