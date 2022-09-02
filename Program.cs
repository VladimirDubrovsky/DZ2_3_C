//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(Holiday(day));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string Holiday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("День недели " + a + " - Выходной");
        }
        else
        {
            Console.Write("День недели " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Нет такого дня недели");
    }
    return " ";
}