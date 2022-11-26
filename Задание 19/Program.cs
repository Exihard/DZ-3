// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите любое число");
var input = Convert.ToInt32(Console.ReadLine());
var input1 = Convert.ToInt32(input);
var output1 = Convert.ToInt32(input);
var output2 = 0;
var count = 0;
while (input1 > 0)
{
    input1 = input1 / 10;
    count += 1;
}
var i = count;
var j = Convert.ToInt32(Math.Pow(10, i-1));
var g = j;
var step = 1;
        //Console.Write($"{input % 10}"); 
        while (step != i)
        {
            output1 /= 10;
            //Console.Write(output1 % 10);
            step = step + 1;
            output2 += (output1 % 10)*j;
            j = j / 10;
        }
        //Console.WriteLine("");
        output2 = (output2 / 10) + ((input % 10)*g);
if(output2 == input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введенное число палиндром!");
    }
else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введенное число не палиндром!");
    }
    Console.ResetColor();