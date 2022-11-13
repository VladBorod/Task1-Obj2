// Задача 1.
// Программа, принимающая на вход два числа и выдает какое число большее, а какое меньшее.

Console.Clear();

// Ввод сравниваемых чисел.

Console.WriteLine("Numbers compare.");

Console.Write("Enter first number: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int numberB = int.Parse(Console.ReadLine());

// Сравнение  чисел.

if (numberA > numberB)
{
    // YES!
    Console.WriteLine($"First = {numberA}, Second = {numberB}, max = {numberA}");
}
else
{
    // No!
    Console.WriteLine($"First = {numberA}, Second = {numberB}, max = {numberB}");
}

// Вывод данных.