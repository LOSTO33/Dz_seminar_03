// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты Xa:");
int numCoordXa = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Ya:");
int numCoordYa = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Za:");
int numCoordZa = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Xb:");
int numCoordXb = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Yb:");
int numCoordYb = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Zb:");
int numCoordZb = int.Parse (Console.ReadLine());
double numCoordAB = Math.Sqrt(Math.Pow(numCoordXb -numCoordXa,2) + Math.Pow(numCoordYb -numCoordYa,2)+ Math.Pow(numCoordZb -numCoordZa,2));
System.Console.WriteLine($"Расстояние {numCoordAB}");
