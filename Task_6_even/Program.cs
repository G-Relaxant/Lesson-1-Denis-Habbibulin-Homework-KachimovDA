Console.WriteLine("Welcome to the program!");
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int remnant = number % 2;
if (remnant == 0)
{
    Console.Write("Your number is even");
}
else
{
    Console.Write("Your number is odd (uneven)");
}

Console.WriteLine("");
Console.Write("Thank you for participating! Program complete^^");