// ДОП ЗАДАЧКА:
// Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();
int size = 1;
Console.Write("Введите целое положительное десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Десятичное число {number} ");
int count = number;
while (number > 1)
{
    number = number / 2;
    size = size + 1;
}
int[] BinaryNumber = new int[size];
size = size - 1;
for (int i = 0; i <= size; i++)
{
    BinaryNumber[size - i] = count % 2;
    count = count / 2;
}
Console.Write("соответствует двоичному числу ");
for (int i = 0; i <= size; i++)
{
    Console.Write($"{BinaryNumber[i]} ");
}