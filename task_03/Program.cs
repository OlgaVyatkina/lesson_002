// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7) {
    string result = (day == 6 || day == 7) ? "Выходной день" : "Не выходной"; 
    Console.WriteLine(result);
    }
else {
    Console.WriteLine("Это не день недели");
    }