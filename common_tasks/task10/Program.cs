//Дано название футбольного клуба. Определить количество символов в нем.

// Console.WriteLine("Введите название футбольного клуба");
// string str = Console.ReadLine()!;

// Console.WriteLine($"Количество символов в названии футбольного клуба {str} - {str.Length} символов");

// //  Дано название города. Определить, четно или нет количество символов в нем.

// Console.WriteLine("Введите название города");
// string siti = Console.ReadLine()!;

// if (siti.Length%2 ==0) Console.WriteLine($"В названии города {siti} - количество символов четное");
// else Console.WriteLine($"В названии города {siti} - количество символов нечетное");


//  Даны две фамилии. Определить, какая из них длиннее.

// Console.WriteLine("Введите две фамилии");
// string lastname1 = Console.ReadLine()!;
// string lastname2 = Console.ReadLine()!;

// int num1 = lastname1.Length;
// int num2 = lastname2.Length;
// int result = 0;

// if (num1 > num2) result = num1 - num2;
// else result = num2 - num1;

// if (lastname1.Length > lastname2.Length) Console.WriteLine($"Фамилия {lastname1} длиннее чем {lastname2} на {result} символа");
// else Console.WriteLine($"Фамилия {lastname2} длиннее чем {lastname1} на {result} символа");

// Даны названия трех городов. Вывести на экран самое длинное и самое короткое название.

Console.WriteLine("Введите название трех городов");
string siti1 = Console.ReadLine()!;
string siti2 = Console.ReadLine()!;
string siti3 = Console.ReadLine()!;

int num1 = siti1.Length;
int num2 = siti2.Length;
int num3 = siti3.Length;

int max = 0;
int min = 0;


if (num1 > num2 && num1 > num2) max = num1;
if (num2 > num1 && num2 > num3) max = num2;
if (num3 > num1 && num3 > num2) max = num3;

if (num1 < num2 && num1 < num2) min = num1;
if (num2 < num1 && num2 < num3) min = num2;
if (num3 < num1 && num3 < num2) min = num3;



Console.WriteLine($"Самое длинное название города это {max}, самое короткое название города это {min}");