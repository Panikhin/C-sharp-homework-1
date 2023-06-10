// Задача: напишите программу, которая на вход принимает два числа и выдает, какое число больше, какое меньше
Console.Clear();
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) 
    Console.WriteLine($"Первое число {numberA} больше второго {numberB}");
if (numberA < numberB) 
    Console.WriteLine($"Первое число {numberA} меньше второго {numberB}");
else
    Console.WriteLine($"Первое число {numberA} равно второму");
    