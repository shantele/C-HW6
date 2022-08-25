// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string ConvertDecimal(int usersDecimal)
{
    string convertedDecimal = "";  // Результат
    while (usersDecimal > 0)
    {
        convertedDecimal += usersDecimal % 2;
        usersDecimal = usersDecimal / 2;
    }
    return convertedDecimal;
}

string tempResult = ConvertDecimal(decimalNumber);

string ReverseResult(string needReverse)
{
    string reversedString = string.Empty;
    for (int i = needReverse.Length - 1; i >= 0; i--)
        reversedString += needReverse[i];
    return reversedString;
}

Console.WriteLine(ReverseResult(tempResult));
