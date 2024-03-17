// Рассчитать значение у при заданном значении х:
// y=sin(x) при x>0 или y=cos(x) в противном случае.

// double x = 90, y;

// if (x > 0)
// {
//     Console.WriteLine(y = Math.Sin(x));
// }
// else
// {
//     Console.WriteLine(y = Math.Cos(x));
// }

// Даны два различных вещественных числа. Определить:
// а) какое из них больше;
// б) какое из них меньше.

// double num1 = -44;
// double num2 = -5;

// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} больше чем {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} меньше чем {num2}");
// }

// . Если целое число m делится нацело на целое число n, 
// то вывести на экран частное от деления, 
// в противном случае вывести сообщение «m на n нацело не делится».

// Console.WriteLine("Введите целые числа m и n");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());

// if (n % m == 0)
// {
//     Console.WriteLine(n / m);
// }
// else Console.WriteLine("m на n нацело не делится");


// Дано натуральное число. Определить:
// а) является ли оно четным;
// б) оканчивается ли оно цифрой 7.

// Console.WriteLine("Введите натуральное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int even = n % 2;
// int seven = n % 10;

// if (even == 0) Console.WriteLine("Число четное");
// else Console.WriteLine("Число не четное");
// if (seven == 7) Console.WriteLine("Число оканчивается на семь");
// else Console.WriteLine("Число не оканчивается на семь");

// Дано двузначное число. Определить:
// а) какая из его цифр больше: первая или вторая;
// б) одинаковы ли его цифры.


// Console.WriteLine("Введите двузначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int first = n / 10;
// int second = n % 10;

// if (first == second)
// { Console.WriteLine("Цифры равны"); }
// else
// {
//     if (first > second)
//     { Console.WriteLine("Первая цифра больше чем вторая"); }
//     else { Console.WriteLine("Вторая цифра больше чем первая"); }
// }

//  Дано двузначное число. Определить, 
//  равен ли квадрат этого числа учетверенной сумме кубов его цифр. 
//  Например, для числа 48 ответ положительный, для числа 52 — отрицательный.


// Console.WriteLine("Введите двузначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int kvad = n * n;
// int first = n / 10;
// int second = n % 10;
// int kub1 = first * first * first;
// int kub2 = second * second * second;
// int kub = 4 * (kub1 + kub2);

// if (kvad == kub) Console.WriteLine($"для числа {n} ответ положительный");
// else Console.WriteLine($"для числа {n} ответ отрицательный");

// Дано двузначное число. Определить:
// а) является ли сумма его цифр двузначным числом;
// б) больше ли числа а сумма его цифр.

// Console.WriteLine("Введите двузначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int first = n / 10;
// int second = n % 10;
// int sum = first + second;

// if (sum > 10 && sum < 99) Console.Write($"Сумма цифр числа {n} является двузначным и оно равно {sum}");
// Console.WriteLine();
// if (n > sum) Console.Write("Введенное число больше чем сумма цифр числа");
// else Console.Write("{Введенное число меньше чем сумма цифр числа");

// Дано трехзначное число. Выяснить, 
// является ли оно палиндромом («перевертышем»), 
// т. е. таким числом, десятичная запись которого 
// читается одинаково слева направо и справа налево

// Console.WriteLine("Введите трехзначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int first = n / 100;
// int third = n % 10;

// if (first == third) Console.Write($"Число {n} является палиндромом");
// else Console.Write($"Число {n} не является палиндромом");

// Дано трехзначное число. Определить:
// а) является ли сумма его цифр двузначным числом;
// б) является ли произведение его цифр трехзначным числом;
// в) больше ли числа а произведение его цифр;
// г) кратна ли пяти сумма его цифр;
// д) кратна ли сумма его цифр числу а.

// Console.WriteLine("Введите трехзначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// int first = n / 100;
// int second = n / 10;
// int third = n % 10;
// int sum = first + second + third;
// int product = first * second * third;

// if (sum > 9 && sum < 100) Console.Write($"Сумма цифр числа {n} является двузначным числом - {sum}");
// Console.WriteLine();
// if (product > 99 && product < 1000) Console.Write($"Произведение цифр числа {n} является трехзначным числом - {product}");
// Console.WriteLine();
// if (n > product) Console.Write($"Число {n} больше чем произведение цифр - {product}");
// Console.WriteLine();
// if (sum % 5 == 0) Console.Write($"Сумма цифр {sum} числа {n} кратна 5");
// Console.WriteLine();
// if (sum % n == 0) Console.Write($"Сумма цифр {sum} числа {n} кратна этому же числу");

// Работа светофора для пешеходов запрограммирована следующим образом: 
// в начале каждого часа в течение трех минут горит зеленый сигнал, 
// затем в течение двух минут — красный, в течение трех минут — опять зеленый и т. д. 
// Дано вещественное число t, означающее время в минутах, 
// прошедшее с начала очередного часа. 
// Определить, сигнал какого цвета горит для пешеходов в этот момент.

Console.WriteLine("Введите время в минутах");
int t = Convert.ToInt32(Console.ReadLine());

int t1 = t % 10;
int hour = 60;
int time = 0;

while (time < hour)
{
    time++;
    if (t1 == 1 || t1 == 2 || t1 == 3 || t1 == 6 || t1 == 7 || t1 == 8)
    {
        Console.WriteLine("В этот момент сигнал светофора горит зеленым");
        break;
    }

    if (t1 == 4 || t1 == 5 || t1 == 9 || t1 == 0)
    {
        Console.WriteLine("В этот момент сигнал светофора горит красным");
        break;
    }
}
