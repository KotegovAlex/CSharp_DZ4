/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

long CalcPow(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = Promt("Введите число а => ");
int b = Promt("Введите число b => ");

long result = CalcPow(a, b);

System.Console.WriteLine($"Результат возведения числа {a} в натуральную степень {b} равен: {result}");