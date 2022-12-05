// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) {Console.WriteLine("Выходной день");}
else if (day <= 5) {Console.WriteLine("Не выходной");}
else if (day > 7) {Console.WriteLine("Это не день недели");}