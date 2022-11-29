// Напишите программу выводящую случайное трехзначное число
// и удаляющую его вторую цифру

Console.Clear();
int randomR = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {randomR}");

int number1 = randomR % 10;
int number2 = randomR / 100;

Console.WriteLine($"Трехзначное число без второй цифры = {number2}{number1}.");





