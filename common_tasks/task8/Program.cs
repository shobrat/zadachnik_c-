// // Даны числа a1, a2, …, a10. Определить их сумму.

// Console.WriteLine("Введите 10 целых чисел");

// double N1 = 0;

// for (int i = 1; i <= 10; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     N1 = N1 + a;
// }
// Console.WriteLine($"Сумма слагаемых равна {N1}");
// // //Console.ReadKey();

// Даны числа a1, a2, …, a10. Определить их сумму.

//  Даны натуральное число n и вещественные числа a1, a2, …, an. 
//  Определить сумму всех вещественных чисел.

// Console.WriteLine("Введите количество слагаемых чисел");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целые числа");

// double N1 = 0;

// for (int i = 1; i <= n; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     N1 = N1 + a;
// }
// Console.WriteLine($"Сумма слагаемых равна {N1}");

// Даны числа a1, a2, …, a6. Определить их произведение.

// Console.WriteLine("Введите количество умножаемых чисел");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целые числа");

// double N1 = 1;

// for (int i = 1; i <= n; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     N1 = N1 * a;
// }
// Console.WriteLine($"Сумма умножаемых чисел равна {N1}");

// Даны числа a1, a2, …, a10. Определить сумму их квадратов.

// Console.WriteLine("Введите количество слагаемых чисел");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целые числа");

// int N1 = 0;
// int kvad = 0;

// for (int i = 1; i <= n; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     kvad = a * a;
//     N1 = N1 + kvad;
// }
// Console.WriteLine($"Сумма слагаемых в квадрате чисел равна {N1}");

// Даны натуральное число n и вещественные числа a1, a2, …, an. 
// Определить среднее арифметическое вещественных чисел.

// Console.WriteLine("Введите количество слагаемых чисел");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целые числа");

// double sum = 0;
// double average = 0;

// for (int i = 1; i <= n; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     sum = sum + a;
// }
// average=sum/n;
// Console.WriteLine($"Сумма среднеарифметических слагаемых чисел равна {average}");

// Даны натуральное число n и числа a1, a2, …, an.. Определить:
// а) |a1| + |a2| + … + |an|;
// б) |a1| x |a2| x … x |an|;
// в) a1 + a2, a2 + a3, …, an-1 + an;
// г) a1 — a2, a2 — a3, …, an-1 — an;


Console.WriteLine("Введите количество слагаемых чисел");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целые числа");

int sum =0;

for (int i = 0; i < n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    sum = sum + Math.Abs(a);
}
 Console.WriteLine(sum);