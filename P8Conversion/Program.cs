// See https://aka.ms/new-console-template for more information

Console.WriteLine(@"A shady man with a deck of cards slips up to you. ´Hey, gimme a number. Any number between 1 and 10!´");

string input = Console.ReadLine();
float a =float.Parse(input); //a = float.Parse(input); //parse a float from string, like 1,23

Console.WriteLine($"Output:"+ a);

//int b = Convert.ToInt32(a); //
int b = (int)a;
Console.WriteLine($"Output:"+b);

int c = Convert.ToInt32(input); //reads a int value from a decimal, doesnt compute if decimal
//Convert input to float like we did above. Or just use float maybe? Will see with experience.
Console.WriteLine($"Output:"+c);
