Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (n == m && n == x && m == x)
{
Console.WriteLine("Все числа не должны быть одинаковыми! \nВведите числа повторно: ");
Console.Write("Введите 1-ое число: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
x = Convert.ToInt32(Console.ReadLine());
}
if (n > m && n>x)
Console.Write(n);
if (m > n && m>x)
Console.Write(m);
if (x > n && x>m)
Console.Write(x);
/* Задача 2: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.*/