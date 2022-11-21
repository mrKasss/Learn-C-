// Напишите программу,которая на 
//1-вход принимает число и 2 
// выдает его квадрат
//Например  
//4 - 16
//3 - 9
//7 - 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32 (Console.ReadLine());

// string str = Console.ReadLine();
// int num Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
