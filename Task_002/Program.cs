// Задача № 13 из ДЗ к семинару 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}
System.Console.WriteLine("Максимальное число для ввода " + int.MaxValue);