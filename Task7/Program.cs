﻿/*
Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int x = Convert.ToInt32(n.ToString()
                            .AsEnumerable()
                            .Last()
                            .ToString());

Console.WriteLine("Последняя цифра:" + x);