// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int n)
{
    int sum = 0;
    for (int i = n; i >= 1; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {n} = {SumOfDigits(n)}");