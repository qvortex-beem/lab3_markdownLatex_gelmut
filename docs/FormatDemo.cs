using System.ComponentModel;
using System.Data.SqlTypes;
using System.Dynamic;

System.Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double sum = number1 + number2;
System.Console.WriteLine($"**Результат операций: {sum}**");
