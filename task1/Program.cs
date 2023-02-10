// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр: {GetCount(num)}");
int GetCount(int number)
{
    int count = 1;
    while (number > 10)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}