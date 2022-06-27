// Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите квадрат введенного числа");
double sqr = Convert.ToDouble(Console.ReadLine());
if (sqr == num*num)
{
    Console.WriteLine("Число " + sqr + " является квадратом числа " + num + ".");
}
else
{
    Console.WriteLine($"Число {sqr} не является квадратом числа {num}.");
}