
// bool A, B, C;

// A = true;
// B = false;
// C = false;

// // bool res_A = A || B; //А или В
// // bool res_B = A && B; //А и В
// // bool res_C = B || C; //B или C

// bool res_A = A || B && !C; //А или В и не С
// bool res_B = !A && !B; //не А и не В
// bool res_C = !(A && C) || B; //не(А и С) или В

// //Console.WriteLine($"{res_A}, {res_B}, {res_C}");
// Console.WriteLine($"{res_A}{res_B}{res_C}");



// Console.WriteLine("Введите два значения");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());


// int x1 = 1, x2 = 1, x3 = 0, x4 = -1, x5 = -1, x6 = 11, x7 = 4;
// int y1 = 2, y2 = 1, y3 = 6, y4 = 3;

// bool A1 = x1 < 2 && y1 < 3;
// bool A2 = x2! < 2; //не верно, что х<2
// bool A3 = x3 < 1 || y2 < 2;
// bool A4 = x4! < 0 && x4! < 5; //неверно, что x < 0 и x < 5;
// bool A5 = x5 < 0 && y3 > 5;
// bool A6 = 10 < x6 && x6 < 20;
// bool A7 = x7 > 3 || x7 < 1;
// bool A8 = y4 > 0 && y4 < 4 && x7 < 5;
// bool A9 = x7 > 3 && x7 < 10;

// Console.WriteLine($"{A1}");
// Console.WriteLine($"{A2}");
// Console.WriteLine($"{A3}");
// Console.WriteLine($"{A4}");
// Console.WriteLine($"{A5}");
// Console.WriteLine($"{A6}");
// Console.WriteLine($"{A7}");
// Console.WriteLine($"{A8}");
// Console.WriteLine($"{A9}");


int A1 = 101, A2 = -1, A3 = 1;
int B1 = 101, B2 = 2, B3 = 2;
int C1 = 6;

bool a1 = A1 > 100 && B1 > 100;
bool a2 = A3 % 2 == 0 || B3 % 2 == 0;
bool a3 = A2 > 0 || B2 > 0;
bool a4 = A1 % 3 == 0 || B1 % 3 == 0 || C1 % 3 == 0;
bool a5 = A1 < 50 || B1 < 50 || C1 < 50;
bool a6 = A2 < 0 || B1 < 0 || C1 < 0;

Console.WriteLine($"{a1}");
Console.WriteLine($"{a2}");
Console.WriteLine($"{a3}");
Console.WriteLine($"{a4}");
Console.WriteLine($"{a5}");
Console.WriteLine($"{a6}");










// а) целое А кратно двум или трем;
// б) целое А не кратно трем и оканчивается нулем.

// int A = int.Parse(Console.ReadLine());

// bool a = A % 2 == 0 | A % 3 == 0;
// bool b = A % 3 != 0 & A % 10 == 0;// т.к. только числа заканчивающиеся на 0 могут дать при делении на 10 остаток 0.

// Console.WriteLine($»a){a}\nb){b}»);
// Console.ReadKey();