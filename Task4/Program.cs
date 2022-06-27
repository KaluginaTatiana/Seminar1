// Создание метода для возведения в квадрат целого числа
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

Metod(num);

void Metod(int currentNumber)
{
    Console.WriteLine(currentNumber * currentNumber);
}