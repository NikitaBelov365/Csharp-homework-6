// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int InputCoord(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = InputCoord("Input b1");
int k1 = InputCoord("Input k1");
int b2 = InputCoord("Input b2");
int k2 = InputCoord("Input k2");

(int, int) intersectionPoint(int b1, int k1, int b2, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1 - k2 * x - b2;
    return (x, y);
}

System.Console.WriteLine($"Intersection point have next coords: {intersectionPoint(b1,k1,b2,k2)}");