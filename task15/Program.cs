// Опредление того, является ли день недели выходным, по его порядковой цифре
void dayOfTheWeek (int number)
{
    if (number >= 1 & number < 6)
    {
        Console.WriteLine (number + " -> нет");
    }
    else
    {
    if (number >= 6 & number < 8)
    {
        Console.WriteLine (number + " -> да");
    }
    else
        Console.WriteLine ("Неправильно введенное число");
    }
}

Console.WriteLine ("Чтобы узнать, является ли день недели выходным, введите его порядковый номер (от 1 до 7): ");
int n = Convert.ToInt32 (Console.ReadLine ());
dayOfTheWeek (n);