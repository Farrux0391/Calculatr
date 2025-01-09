using System;

System.Console.WriteLine("1-sonni kiriting: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("2-sonni kiriting: ");
int secondNumber =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"1-son 2-sondan katta: {firstNumber > secondNumber}");
System.Console.WriteLine($"1-son 2-sondan kichik: {firstNumber < secondNumber}");
System.Console.WriteLine($"1-son 2-sondan katta yoki teng: {firstNumber >= secondNumber}");
System.Console.WriteLine($"1-son 2-sondan kichik yoki teng: {firstNumber <= secondNumber}");
System.Console.WriteLine($"1-son 2-son bilan teng: {firstNumber == secondNumber}");
System.Console.WriteLine($"1-son 2-son bilan teng emasmi?: {firstNumber != secondNumber}");
