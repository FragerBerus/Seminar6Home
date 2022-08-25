// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int pozitivNumber = 0;
Console.Write("Введите длину массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[lengthArray];
if (lengthArray > 0)
{
    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write($"Введите целочисленный {i + 1} элемент массива из {lengthArray}: ");
        ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
        if (ArrayNumbers[i] > 0)
        {
            pozitivNumber = pozitivNumber + 1;
        }
    }
}
else
{
    Console.WriteLine("Введена неверная длина массива!!!");
}
Console.WriteLine($"Положительных чисел в массиве: {pozitivNumber}.");