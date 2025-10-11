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
