﻿// Задача: напишите программу, которая на вход принимает число и выдает, являетли ли число четным
Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine($"Number {number} is even");
else 
    Console.WriteLine($"Number {number} is odd");
