// Найти:
// а) сумму всех целых чисел от 100 до 500;
// б) сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a<500);
// в) сумму всех целых чисел от –10 до b (значение b вводится с клавиатуры; b>–10);
// г) сумму всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).

// Console.WriteLine("Для создания цикла суммирования значений введите минимальное число");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = min; i <= max; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма целых чисел от 100 до 500 равна {sum}");



// Console.WriteLine("Для создания цикла суммирования значений введите минимальное число");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = min; i < max; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма целых чисел от a до b равна {sum}");


// Найти:
// а) произведение всех целых чисел от 8 до 15;
// б) произведение всех целых чисел от a до 20 (значение a вводится с клавиатуры; 1<=a<=20);
// в) произведение всех целых чисел от 1 до b (значение b вводится с клавиатуры; 1<=b<=20);
// г) произведение всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).


// Console.WriteLine("Для создания цикла умножения значений введите минимальное число");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// int product = 1;

// for (int i = min; i <= max; i++)
// {
//     product = product * i;
// }
// Console.WriteLine($"Произведение целых чисел от {min} до {max} равна {product}");

// . Найти:
// а) среднее арифметическое всех целых чисел от 1 до 1000;
// б) среднее арифметическое всех целых чисел от 100 до b (значение b вводится с клавиатуры; b>100);
// в) среднее арифметическое всех целых чисел от a до 200 (значения a и b вводятся с клавиатуры; a<200);
// г) среднее арифметическое всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).

// Console.WriteLine("Для создания цикла умножения значений введите минимальное число");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// double sum = 0;
// double result = 0;

// for (int i = min; i <= max / 2; i++)
// {
//     sum = min + max;
//     result = result + sum;
//     Console.WriteLine(result);
// }

// double average = result / max;
// Console.WriteLine(average);

// Найти:
// а) сумму кубов всех целых чисел от 20 до 40;
// б) сумму квадратов всех целых чисел от a до 50 (значение a вводится с клавиатуры; 0<a<=50);
// в) сумму квадратов всех целых чисел от 1 до n (значение n вводится с клавиатуры; 1<=n<=100);
// г) сумму квадратов всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).


// Console.WriteLine("Для создания суммы кубов всех целых чисел от А до В введите минимальное число");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// int sum=0;
// int kub=0;

// for (int i = min; i <= max; i++)
// {
//     kub = i*i*i;
//     sum = sum+kub;
// }
// Console.WriteLine(sum);

// Дано натуральное число n. Найти сумму:  n2 + (n+1)2 + … + (2n)2.

Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());

int result = 0;
int sum = 0;

for (int i = 1; i < n; i++)
{
    result = (2 * n) * 2;
    sum = sum + result;
    Console.WriteLine(sum);

}

Console.WriteLine(result);
