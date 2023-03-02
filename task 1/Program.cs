// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayCreation(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Input {i+1} value:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.WriteLine($"{item} ");
    }
    System.Console.WriteLine();
}

void Counter(int[] array)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item > 0) counter++;
    }
    System.Console.WriteLine($"User entered {counter} numbers greater than 0");
}

int size = InputSize("Input ammount of numbers that you want to enter");
int[] array = ArrayCreation(size);
PrintArray(array);
Counter(array);