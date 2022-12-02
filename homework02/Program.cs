//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int num, sum = 0, a;
Console.WriteLine("Введите число : ");
num = int.Parse(Console.ReadLine());
while (num != 0)
{
    a = num % 10;
    num = num / 10;
    sum = sum + a;
}
Console.WriteLine("Сумма цифр числа:  " + sum);
Console.ReadLine();