




























void thirdNumber (int number)
{
 if (number / 100 > 1)
    {
        if (number > 100 & number < 1000)
        {
            Console.WriteLine (number + " -> " + number % 10);
        }
        else
        {
        Console.Write (number + " -> ");
            while (number > 1000)
            {
            number = number / 10;
            }
        Console.WriteLine (number % 10);
        }
    }
    else
    {
        Console.WriteLine (number + " -> " + "третьей цифры нет");
    }
}
   
Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine ());
thirdNumber (n);