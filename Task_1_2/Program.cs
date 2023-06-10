// Задача: напишите программу, которая на вход принимает два числа и выдает, какое число большее, какое число меньшее
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
    Console.WriteLine($"Певое число {a} больше второго {b}");
else if (a < b)
    Console.WriteLine($"Певое число {a} меньше второго {b}");
else
    Console.WriteLine($"Певое число {a} равно второму");

