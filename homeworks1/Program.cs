﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

*/
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
 Console.WriteLine("Первое число больше второго");
}
else if (num1 < num2)
{
Console.WriteLine("Первое число меньше второго"); 
}
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
{
Console.WriteLine(max); 
}
*/
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Введи число");
int num;
num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
 Console.WriteLine("четное число"); 
}
else
{
   Console.WriteLine("не четное число"); 
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

/*
Console.Write("Write number 1: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Write number 2: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)

if (i % 2 == 0) 
{
Console.Write(i + " ");
}

Console.ReadKey();*/
