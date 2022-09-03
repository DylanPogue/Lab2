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
int maxNumber;

Console.Write("Enter the number you would like to see the multiplication tables of: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("How many multiplications would you like to see?");
maxNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < maxNumber; i++)
{
    Console.WriteLine($"{num1} * {i} = {num1 * i}");
}

// #3 Output the number of bytes in memory

ConsoleTable table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);
table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);
table.AddRow("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
Console.WriteLine("Press any key to display the table.");
Console.ReadKey();
Console.WriteLine(table);

for (int i = 0; i < 10000; i++)
{
    string operation;
    Console.Write("If at any point you decide to exit just type your first number and read the following instructions." +
        "\nEnter your first number: ");
    num1 = Convert.ToInt32((Console.ReadLine()));

    Console.Write($"Enter your operation +, -, *, /, % \n or if you want to exit, type 'exit' ");
    operation = Console.ReadLine();
    if (operation == "exit")
    {
        Environment.Exit(0);
    }


    Console.Write("Enter your second number: "); ;
    num2 = Convert.ToInt32((Console.ReadLine()));


    if (operation == "+")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 + num2));
    }
    else if (operation == "-")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 - num2));
    }
    else if (operation == "*")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 * num2));
    }
    else if (operation == "/")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 / num2));
    }
    else if (operation == "%")
    {
        Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + (num1 % num2));
    }
}