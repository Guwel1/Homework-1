Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
while (n == m)
{
Console.WriteLine("Числа не должны быть одинаковыми! \nВведите числа повторно: ");
Console.Write("Введите 1-ое число: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
m = Convert.ToInt32(Console.ReadLine());
}
if (n > m)
Console.Write(n);
else
Console.Write(m);
/* Задача 2: Напишите программу, которая на вход принимает
 два числа и выдаёт, какое число большее, а какое меньшее.*/