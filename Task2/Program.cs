/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

// ввод числа
string Promt(string msg)
{
    System.Console.WriteLine(msg);
    string number = Console.ReadLine();
    return number;
}
// сумма цифр цисла
int SumDigits(string number)
{
    int summ = 0;
    for (int i = 0; i < number.Length; i++)
    {
        summ = summ + int.Parse(number[i].ToString());
    }
    return summ;
}

string number = Promt("Введите число N => ");
int result = SumDigits(number);
System.Console.WriteLine($"Сумма цифр цисла {number} равна => {result}");