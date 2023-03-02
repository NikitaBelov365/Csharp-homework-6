// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double InputCoord(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = InputCoord("Input b1");
double k1 = InputCoord("Input k1");
double b2 = InputCoord("Input b2");
double k2 = InputCoord("Input k2");

(double, double) intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

System.Console.WriteLine($"Intersection point have next coords: {intersectionPoint(b1,k1,b2,k2)}");