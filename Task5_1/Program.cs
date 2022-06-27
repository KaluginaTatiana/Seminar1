// Программа, которая на вход принимает одно целое число (N) как положительное, так и отрицательное, 
// а на выходе показывает все целые числа в промежутке от -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
//- 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
Console.WriteLine("Введите целое число");
double num = Convert.ToDouble(Console.ReadLine());
num = Math.Abs(num);
if (num % 1 == 0)
{
    double count = -num;
    while (count <= num)
    {
        Console.Write($" {count},");
        count = count + 1;
    }
    Console.Write("\b");
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine("Ошибка. Число должно быть целым. Попробуйте еще раз.");
}