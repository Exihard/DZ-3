// Задача 23: Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число до которого вуывести таблицу кубов:");
var interval = Convert.ToInt32(Console.ReadLine());
var intermediateNum = Convert.ToInt32(0);
var i = Convert.ToInt32(1);

while (i <= interval)
{
    intermediateNum = Convert.ToInt32(Math.Pow((i),3));
    Console.WriteLine($"{intermediateNum} ");
    i = i+1;
}
