// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System.Reflection;

Random rd = new Random();
int num1 = rd.Next();
Console.WriteLine(num1);
if (num1<100)
{
Console.WriteLine("u havnt a third figure in num");
}
else
{

    int index = 2;
    string s = num1.ToString();
    Console.WriteLine (s[index]);
}