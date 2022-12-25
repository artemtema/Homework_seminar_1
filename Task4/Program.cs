Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}