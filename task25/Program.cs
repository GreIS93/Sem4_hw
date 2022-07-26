// Задача 25: Напишите цикл, который принимает на вход
// два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243
// 2, 4 -> 16

int Exponantiation(int a, int b)
{
    if (b == 0) return 1;
    else if (b == 1) return a;
    else return a * Exponantiation(a, b - 1);
}

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Exponantiation(a, b));