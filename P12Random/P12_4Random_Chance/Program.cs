// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Are you the one?");
//Console.ReadLine();
double TheOne = 0.1;
double roll = Random.Shared.NextDouble(); 
bool success = roll < TheOne;
if (success)
{
    Console.WriteLine("You are the one!");
}
else if (!success)
{
    Console.WriteLine("You are not the one! Try again.");
}