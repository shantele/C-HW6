// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество значений: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите число №{0}: ", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введенные числа: {String.Join(", ", array)}");

int countPositive = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0) countPositive++;
}

Console.WriteLine($"Количество чисел больше 0: {countPositive}");