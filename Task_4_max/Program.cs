Console.WriteLine("Welcome to the program!");
Console.Write("Input first integer number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int accum = 0;

if (number1 > number2)
{
    accum = number1;
}
else
{
    accum = number2;
}

if (accum > number3)
{
    Console.Write("Max number = " + accum);
}
else
{
    Console.Write("Max number = " + number3);
}

Console.WriteLine("");
Console.Write("Thank you for participating! Program complete^^");