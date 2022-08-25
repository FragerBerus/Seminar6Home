// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
// k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
string ratio = "b";
float[,] ArrayRatio = new float[2, 2];
for (int k = 0; k < (ArrayRatio.GetLength(0)); k++)
{
    for (int b = 0; b < (ArrayRatio.GetLength(1)); b++)
    {
        Console.Write("Введите значение коэффициента ");
        Console.Write($"{ratio}{b + 1}: ");
        ArrayRatio[b, k] = Convert.ToSingle(Console.ReadLine());
    }
    ratio = "k";
}
if (ArrayRatio[0, 1] != ArrayRatio[1, 1])
{
    float intersectionX = (ArrayRatio[1, 0] - ArrayRatio[0, 0]) / (ArrayRatio[0, 1] - ArrayRatio[1, 1]);
    float intersectionY = ArrayRatio[0, 1] * intersectionX + ArrayRatio[0, 0];
    Console.WriteLine($"Координаты пересечения двух прямых: X = {intersectionX}, Y = {intersectionY}");
}
else
{
    Console.WriteLine("Прямые не имеют точки пересечения. т.к. параллельны.");
}