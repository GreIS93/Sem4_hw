// Задача 29: Напишите программу, которая задаёт массив из 8 случайных 
// целых чисел и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

void FillArray(int[] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(start, end); ;
    }
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
    Console.WriteLine();
}

void AbsSortArray(int[] arr2)
{
    int tmp = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        for (int j = 0; j < arr2.Length - 1; j++)
        {
            if (Math.Abs(arr2[j]) > Math.Abs(arr2[j + 1]))
            {
                tmp = arr2[j+1];
                arr2[j + 1] = arr2[j];
                arr2[j] = tmp;
            }
        }
    }
}

int[] array = new int[8];

FillArray(array, -19, 20);
PrintArray(array);
Console.WriteLine();
AbsSortArray(array);
PrintArray(array);
