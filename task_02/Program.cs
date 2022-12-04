// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
string N = Console.ReadLine() ?? "";
if ((N.Length-1) < 2) {
  Console.WriteLine("Третьей цифры нет");  
}
else {
    Console.WriteLine(N[2]); 
}