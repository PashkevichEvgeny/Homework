// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] Coord()
{
    string[] name = { "b1", "k1", "b2", "k2" };
    double[] arrayCoord = new double[4];
    for (int i = 0; i < arrayCoord.Length; i++)
    {
        Console.Write($"Введите данные {name[i]}: ");
        arrayCoord[i] = double.Parse(Console.ReadLine()!);
    }
    return arrayCoord;
}


bool Cross(double b1, double k1, double b2, double k2, out double x, out double y)
{
    if (k1 == k2 || b1 == b2)
    {
        x = double.NaN;
        y = double.NaN;
        return false;
    }
    
    y = (k1 * b2 - k2 * b1) / (k1 - k2);
    x = (y - b1) / k1;
    return true;
}

double[] a = Coord();
bool answer = Cross(a[0], a[1], a[2], a[3], out double x, out double y);
if (answer)
{
    System.Console.WriteLine($"{x} {y}");
}
else
{
    Console.WriteLine("Прямые совпадают или параллельны");
}