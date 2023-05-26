// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System.Globalization;

Console.WriteLine("take a three - digit num pls");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1>99 && 10000>num1)
{
    int result = num1 % 100;
    int res = result / 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("u wrote not a three -Digit num");
}