// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

string? input;
do
{
    Console.Write("Enter a binary number: ");
    input = Console.ReadLine();

    if (validate(input))
        Console.WriteLine(BinToDec(input));
    else
    {
        Console.WriteLine("Binary number not entered, please try again: ");
    }
}
while (input != "-1");

int BinToDec(string? input)
{
    return Convert.ToInt32(input, 2);  
}

bool validate(string? input)
{
    if (input == null) { return false; }
    if (input == "") { return false; }
    foreach (char c in input)
    {
        if (c < '0' || c > '1') { return false; }
    }
    return true;
}