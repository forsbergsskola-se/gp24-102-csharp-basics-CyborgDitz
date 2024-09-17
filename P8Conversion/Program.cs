// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"A shady man with a deck of cards slips up to you. ´Hey, gimme a number. Any number between 1 and 10!´");

string input = Console.ReadLine();
float a =float.Parse(input); //a = float.Parse(input); //parse a float from string

Console.WriteLine($"Output:"+ a);

int b = Convert.ToInt32(a);
Console.WriteLine($"Output:"+b);

