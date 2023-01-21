// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    Console.Write($"{arr[0]}");
    if (arr.Length == 1)
    {
        Console.Write("]");
    }
    else
    {
        int position = 1;
        while (position < arr.Length)
        {
            Console.Write($", {arr[position]}");
            position++;
        }
    }
}

int[] CreateArrayAnyLengthFromConsole()
{
    int[] arr = new int[0];

    Console.WriteLine("Введите числа массива. По завершении введите \"q\"");

    string N = Console.ReadLine();

    while (N != "q")
    {
        Array.Resize(ref arr, arr.Length + 1);
        int i = arr.Length - 1;
        arr[i] = Convert.ToInt32(N);
        N = Console.ReadLine();
    }
    return arr;
}

int CounterPositiveNumbers(int[] arr)
{
    int count = 0;
    foreach (var i in arr)
    {
        if (i > 0) count++;
    }
    return count;
}

Console.Clear();

int[] array = CreateArrayAnyLengthFromConsole();

Console.Clear();

PrintArray(array);

int result = CounterPositiveNumbers(array);

Console.Write($" -> {result}");