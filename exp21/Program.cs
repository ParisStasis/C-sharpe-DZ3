// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int x1 = ReadInt("Введите координату Х точки один ");
int y1 = ReadInt("Введите координату Y точки один ");
int z1 = ReadInt("Введите координату Z точки один ");
int x2 = ReadInt("Введите координату Х точки два  ");
int y2 = ReadInt("Введите координату Х точки два  ");
int z2 = ReadInt("Введите координату Х точки два  ");

int a = x2-x1;
int b = y2-y1;
int c = z2-z1;

double length = Math.Sqrt( a*a + b*b + c*c );
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
