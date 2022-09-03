using ConsoleTables;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// #1 print the output of adding two numbers from use input
int num1, num2;
Console.WriteLine("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

// #2 Multiply table
int bigNumber;

Console.Write("Enter the number you like to use ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number you would like to use for the multiplication table:");
bigNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < bigNumber; i++)
{
    Console.WriteLine($"{num1} * {i} = {num1 * i}");
}