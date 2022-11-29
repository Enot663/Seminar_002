Console.Clear();
int randomDigit = new Random().Next(10, 100); // вводим случайное число
// с помощью рандомной операции

Console.WriteLine($"Случайное число: {randomDigit}"); // выводим случайное число на консоль

int number1 = randomDigit % 10; // находим последнюю цифру путем деления на 10 без остатка
Console.WriteLine($"Последняя цифра: {number1}"); // выводим на консоль

int number2 = randomDigit / 10; // находим первую цифру путем деления на 10 
Console.WriteLine($"Первая цифра: {number2}"); // выводим на консоль


if (number1>number2)
    Console.WriteLine($"Максимальное число: {number1}");

else
    Console.WriteLine($"Максимальное число: {number2}");
