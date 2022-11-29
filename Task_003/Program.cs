// Написать программу которая будет принимать на вход два числа и выводить является ли 
// второе число кратное первому. Если число 2 не кратно числу 1, программа выводит 
// остаток от деления
Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int res = num1 % num2;

if (res == 0)
    Console.WriteLine($"{num2}; {num1} -> кратно");
else
    Console.WriteLine($"{num2}; {num1} -> не кратно, остаток {res} ");




