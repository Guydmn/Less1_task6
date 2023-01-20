// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;

if (b == 0)
Console.Write($"Число {a} четное");
else 
Console.Write($"Число {a} нечетное");