// Дано двузначное число. Найти:
// а) число десятков в нем;
// б) число единиц в нем;
// в) сумму его цифр;
// г) произведение его цифр.


// Console.WriteLine("Введите двузначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = num / 10;
// int num3 = num % 10;
// int num4 = num2 + num3;
// int num5 = num2 * num3;

// Console.WriteLine($"Число десятков равно {num2}");
// Console.WriteLine($"Число едениц равно {num3}");
// Console.WriteLine($"Сумма цифр равна {num4}");
// Console.WriteLine($"Произведение цифр равна {num5}");
// Console.WriteLine($"Перестановка цифр равна {num3}{num2}");


Console.WriteLine("Введите четырехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num / 10;
int num7 = num / 10 % 10;
int num3 = num % 10;
int num6 = num / 100 % 10;
int num8 = num / 1000;

int num4 = num7 + num3 + num6;
int num5 = num7 * num3 * num6;

Console.WriteLine($"Число тысяч равно {num8}");
Console.WriteLine($"Число сотен равно {num6}");
Console.WriteLine($"Число десятков равно {num7}");
Console.WriteLine($"Число единиц равно {num3}");

Console.WriteLine($"Сумма цифр равна {num4}");
Console.WriteLine($"Произведение цифр равна {num5}");

Console.WriteLine($"Перестановка цифр равна {num3}{num7}{num6}");

Console.WriteLine($"1 - перестановка цифр равна {num3}{num7}{num6}{num8}");
Console.WriteLine($"2 - перестановка цифр равна {num6}{num3}{num7}");
Console.WriteLine($"3 - перестановка цифр равна {num7}{num6}{num3}");
Console.WriteLine($"4 - перестановка цифр равна {num7}{num3}{num6}");
Console.WriteLine($"5 - перестановка цифр равна {num3}{num6}{num7}");
Console.WriteLine($"6 - перестановка цифр равна {num3}{num7}{num6}");
