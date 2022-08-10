// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber >= 100 & firstNumber <= 999)
{
    int SecondDigit (int number)
    {
        int result = (firstNumber/10)%10;
        return result;
    }
Console.WriteLine(SecondDigit(firstNumber));
}
else
{
    Console.WriteLine ("Число не трёхзначное:");
}

