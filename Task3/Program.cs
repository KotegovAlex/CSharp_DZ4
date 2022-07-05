/* Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

// Генерация массива
int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Вывод массива в строку
void PrintArray(int[] array)
{
    System.Console.Write("[" + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.Write("]");
}

System.Console.WriteLine("Введите длину массива: ");
int[] array = GenerateArray(int.Parse(Console.ReadLine()), 1, 100);
PrintArray(array);