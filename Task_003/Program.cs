// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной день");
    }
}
else
{
    Console.WriteLine("Введено неверное число. В неделе 7 дней");
}