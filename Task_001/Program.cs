// Задача № 10 из ДЗ к семинару 2. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.WriteLine((number / 10) % 10);
}
else
{
    Console.WriteLine("Введено нетрехзначное число");
}