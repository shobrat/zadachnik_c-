// Console.WriteLine("Введите число x");
// int x = Convert.ToInt32(Console.ReadLine());

// int y=7*(x*x)+3*x+6;

// Console.WriteLine(y);

// Console.WriteLine("Введите число в сантиметрах");
// int a = Convert.ToInt32(Console.ReadLine());

// int b = a / 100;
// if (b == 1)
// {
//     Console.WriteLine($"{a} cантиметров равно {b} полному метру");
// }
// else
// {
//     Console.WriteLine($"{a} cантиметров равно {b} полным метрам");
// }

// Console.WriteLine("Введите количество дней");
// int c= Convert.ToInt32(Console.ReadLine());

// int d = c / 7;

// if (d == 1)
// {
//     Console.WriteLine($"{c} дней равно {d} неделе");
// }
// else
// {
//     Console.WriteLine($"{c} дней равно {d} неделям");
// }

// Console.WriteLine("Введите количество секунд");
// int sek= Convert.ToInt32(Console.ReadLine());

// int hour = sek / 3600;

// if (hour == 1)
// {
//     Console.WriteLine($"{sek} секунд равно {hour} часу");
// }
// else
// {
//     Console.WriteLine($"{sek} секунд равно {hour} часам");
// }

//  Дано целое число k (1 ≤ k ≤ 365). Присвоить целочисленной величине n значение 
//  1, 2, …, 6 или 0 в зависимости от того, на какой день недели 
//  (понедельник, вторник, …, субботу или воскресенье) приходится k-й день года, в котором 1 января:
// а) понедельник;
// б) вторник;
// в) d-й день недели (если 1 января — понедельник, то d=1, если вторник — d=2, …, если воскресенье — d=7).

Console.WriteLine("Введите K-ый день года, от 1 до 365 дня включительно");
int K = Convert.ToInt32(Console.ReadLine());

int remainder = (Math.Abs(K - 7) + 7) % 7;
int n = 0;
string day = "";

switch (remainder)
{
    case 0: n = 1; day = "Понедельник"; break; // Понедельник
    case 1: n = 2; day = "Вторник"; break; // Вторник
    case 2: n = 3; day = "Среда"; break; // Среда
    case 3: n = 4; day = "Четверг"; break; // Четверг
    case 4: n = 5; day = "Пятница"; break; // Пятница
    case 5: n = 6; day = "Суббота"; break; // Суббота
    case 6: n = 0; day = "Воскресенье"; break; // Воскресенье
}
Console.Write($"{K} - ый день года приходиться на {day}");

// Console.WriteLine("Введите целое число от 1 до 365");
// int k = Convert.ToInt32(Console.ReadLine());


// if (k >= 365) Console.WriteLine("Вы ввели неправильное число");

// // int day = 0;
// int min = 1;
// //int max = 365;

// int d1 = int.Parse("Понедельник");
// int d2 = int.Parse("Вторник");
// int d3 = int.Parse("Среда");
// int d4 = int.Parse("Четверг");
// int d5 = int.Parse("Пятница");
// int d6 = int.Parse("Суббота");
// int d7 = int.Parse("Воскресенье");

// if (min == d1)
// {
//     int week = k % 7;
//     if (week == 0) Console.WriteLine($"{k} день - это {d7}");
//     if (week == 1) Console.WriteLine($"{k} день - это {d1}");
//     if (week == 2) Console.WriteLine($"{k} день - это {d2}");
//     if (week == 3) Console.WriteLine($"{k} день - это {d3}");
//     if (week == 4) Console.WriteLine($"{k} день - это {d4}");
//     if (week == 5) Console.WriteLine($"{k} день - это {d5}");
//     if (week == 6) Console.WriteLine($"{k} день - это {d6}");
// }


// // NewMethod(k);
// // static void NewMethod(int k)
// // {
// int num2 = 7;
// if (k >= min && k <= max)
// {
//     for (int i = 0; i < num2; i++)
//     {
//         if (week == 0) Console.WriteLine($"{k} день - это {d1}");
//     }
//     int week = k % 7;
//     if (week == 0) Console.WriteLine($"{k} день - это {d1}");
//     if (week == 1) Console.WriteLine($"{k} день - это Понедельник");
//     if (week == 2) Console.WriteLine($"{k} день - это Вторник");
//     if (week == 3) Console.WriteLine($"{k} день - это Среда");
//     if (week == 4) Console.WriteLine($"{k} день  - это Четверг");
//     if (week == 5) Console.WriteLine($"{k} день - это Пятница");
//     if (week == 6) Console.WriteLine($"{k} день - это Суббота");
// }
// // }