// Задача: напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number < 2)
    Console.WriteLine("Ошибка. Четных чисел от 1 до введенного числа нет");
else
{
    while (count <= number)
        {
        Console.WriteLine(count);
        count += 2;
        }
}
