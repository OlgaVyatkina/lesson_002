// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day < 6) {Console.WriteLine("Не выходной )");}
else {Console.WriteLine("Выходной день!");}
