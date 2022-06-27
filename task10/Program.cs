void printSecondNumber (int number)
{
    int secondNumber = number / 10 % 10;
    Console.WriteLine (number + " -> " + secondNumber);
}

Console.WriteLine ("Введите трехзначное число: ");
int n = Convert.ToInt32 (Console.ReadLine ());
printSecondNumber (n);