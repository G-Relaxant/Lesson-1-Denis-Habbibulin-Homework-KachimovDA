Console.WriteLine("Welcome to the program!");
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 4;

if (number >= 1)
{
    if (number == 1)
    {
    Console.Write("You input number 1 - in this range of values even numbers are missing");
    }
    else
    {
        Console.Write("Even numbers in set range: 2");
        while (index <= number)
        {
            Console.Write(", ");
            Console.Write(index);
            index = index + 2;
        }
    }
}    
else
{
    Console.Write("Your number is incorrect, please restart program and input correct number");
}

Console.WriteLine("");
Console.Write("Thank you for participating! Program complete^^");