// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X точки A:");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A:");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A:");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B:");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B:");
int Zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
Console.WriteLine($"{distance:f2}");