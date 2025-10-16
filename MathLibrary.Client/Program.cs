using MathLibraryYacenko;
using System;

Console.WriteLine("Демонстрация работы MathLibrary.dll");

double x = 10, y = 4;

Console.Write($"Сложение чисел {x} + {y} = ");
Console.WriteLine(Calculator.Add(x, y));

Console.Write($"Вычитание второго числа из первого {y} - {x} = ");
Console.WriteLine(Calculator.Substract(x, y));

Console.Write($"Умножение чисел {x} * {y} = ");
Console.WriteLine(Calculator.Multiply(x, y));

Console.Write($"Деление чисел без ошибки {x} / {y} = ");
Console.WriteLine(Calculator.Divide(x, y));

double a = 2, b = 0;

Console.Write($"Деление чисел без ошибки {a} / {b} = ");
Console.WriteLine(Calculator.Divide(a, b));

Console.WriteLine("Проверка чисел на простоту");

int[] numbersToCheck = { 1, 2, 3, 4, 17, 25, 97, 997};

for (int i = 0; i < numbersToCheck.Length; i++)
{
    int num = numbersToCheck[i];
    bool isPrime = Calculator.IsPrime(num);
    Console.WriteLine($"Число {num} является простым? -> {isPrime}");
}

int z = 6, power = 3;
Console.Write($"Возведение {x} в {power} степень числа = ");
Console.WriteLine(Calculator.Power(z, power));

int q = 12;
Console.Write($"Факториал {q} = ");
Console.WriteLine(Calculator.Factorial(q));

Console.Write($"Факториал {q} = ");
Console.WriteLine(Calculator.Factorial(q));

double? x1, x2;
Calculator.SolveQuadratic(1, -4, 4, out x1, out x2);
Console.WriteLine($"\nУравнение: x² - 4x + 4 = 0");
Console.WriteLine($"Корни: x1 = {x1}, x2 = {x2}");
// Вывод: Корни: x1 = 2, x2 = null


Calculator.SolveQuadratic(1, -3, 2, out x1, out x2);
Console.WriteLine($"Уравнение: x² - 3x + 2 = 0");
Console.WriteLine($"Корни: x1 = {x1}, x2 = {x2}");
// Вывод: Корни: x1 = 2, x2 = 1