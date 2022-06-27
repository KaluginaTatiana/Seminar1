// Напишите программу, которая на вход принимает число и на выход выдает его квадрат.
Console.WriteLine("Введите число, которое нужно возвести в квадрат");
double num = Convert.ToDouble(Console.ReadLine());
double sqr = Math.Pow(num, 2);
// double sqr = num*num; - можно и так
Console.WriteLine($"Квадрат числа {num} равен {sqr}");
Console.WriteLine("Квадрат числа " + num + " равен " + sqr + ".");