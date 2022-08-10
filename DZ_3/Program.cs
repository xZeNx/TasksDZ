// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введи цифру дня недели");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6 || Number == 7)
{
    Console.WriteLine("Выходной день");
}
else if (Number < 1 || Number > 7)
{
    Console.WriteLine("В неделе семь дней!");
}
else
    Console.WriteLine("Это не выходной");