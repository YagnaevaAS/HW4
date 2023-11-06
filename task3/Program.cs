// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt (string message)
{
    Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] CreateArray (int Length, int minVal, int maxVal)
{
    int [] array = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minVal, maxVal +1);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt ("Укажите длину массива: ");
int min  = Prompt ("Минимальное значение случайного числа: ");
int max = Prompt ("Максимальное значение случайного числа: ");
int[] array = CreateArray(length, min, max);
PrintArray(array);
