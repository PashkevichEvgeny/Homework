// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

// Двумерный массив с названиями точек
char[,] pointName = {{'A', 'x'}, {'A', 'y'}, {'A', 'z'}, 
                       {'B', 'x'}, {'B', 'y'}, {'B', 'z'}};
int amountOfPoints = pointName.GetLength(0);
int[] coordArray = new int[amountOfPoints];

for (int i = 0; i < amountOfPoints; i++)
{
    Console.Write($"Введите координату точки {pointName[i, 0]} по оси {pointName[i, 1]}: ");
    coordArray[i] = int.Parse(Console.ReadLine()!);
}
double distance = Math.Sqrt(Math.Pow((coordArray[0] - coordArray[3]), 2) +
                            Math.Pow((coordArray[1] - coordArray[4]), 2) +
                            Math.Pow((coordArray[2] - coordArray[5]), 2));
Console.WriteLine($"{distance:f2}");

/*
// Сокращенный вариант. Запись трех координат в один массив
Console.Clear();
Console.Write("Введите координаты первой точки через запятую: ");
int[] A = Array.ConvertAll(Console.ReadLine()!.Split(','), int.Parse);
Console.Write("Введите координаты второй точки через запятую: ");
int[] B = Array.ConvertAll(Console.ReadLine()!.Split(','), int.Parse);

double dis = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) +
                       Math.Pow((B[1] - A[1]), 2) +
                       Math.Pow((B[2] - A[2]), 2));
Console.WriteLine($"{Math.Round(dis, 2)}");
*/
