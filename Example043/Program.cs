// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
// k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите значение коэффициента b1: ");
float ratioB1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите значение коэффициента k1: ");
float ratioK1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите значение коэффициента b2: ");
float ratioB2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите значение коэффициента k2: ");
float ratioK2 = Convert.ToSingle(Console.ReadLine());
if (ratioK1 != ratioK2)
{
    float intersectionX = (ratioB2 - ratioB1) / (ratioK1 - ratioK2);
    float intersectionY = ratioK1 * intersectionX + ratioB1;
    Console.WriteLine($"Координаты пересечения двух прямых: X = {intersectionX}, Y = {intersectionY}");
}
else
{
    Console.WriteLine("Прямые не имеют точки пересечения. т.к. параллельны.");
}
