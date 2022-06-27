// Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
Console.WriteLine("Введите целое положительное число");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 1 == 0)
{
    if (num > 0)
    {
        double count = -num;
        while (count <= num)
        {
            Console.Write($" {count},");
            count = count +1;
        }
        Console.Write("\b");
        Console.WriteLine(" ");
    }
    else
    {
        Console.WriteLine("Ошибка. Число должно быть положительным. Попробуйте еще раз.");
    }
}
else
{
    Console.WriteLine("Ошибка. Число должно быть целым. Попробуйте еще раз.");
}