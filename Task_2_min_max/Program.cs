Console.WriteLine("Welcome to the program!");
Console.Write("Input first integer number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Max = " + number1 + ", ");
    Console.Write("Min = " + number2);
}
else
{
    Console.Write("Max = " + number2 + ", ");
    Console.Write("Min = " + number1);
}
Console.WriteLine("");
Console.Write("Thank you for participating! Program complete^^");