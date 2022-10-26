/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
(Использовать только математические операции, нельзя использовать число как строку по типу number[2])

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введие число: ");

int number = Convert.ToInt32(Console.ReadLine());
int mainNumber = number;

if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"{mainNumber} -> {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}