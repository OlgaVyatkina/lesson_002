// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число:");
string N = Console.ReadLine() ?? "";
if ((N.Length-1) < 2) {
Console.WriteLine("Число не трехзначное"); }
else {
Console.WriteLine(N[1]);
}
