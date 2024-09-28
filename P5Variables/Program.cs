// See https://aka.ms/new-console-template for more information

string a;
string b;
//defines variables
a = "Hello";

// a variable is Hello
Console.WriteLine(a);
//prints Hello AKA a
a = "world";
Console.WriteLine(a);
//Replaces old variable value, outprints world
b = a;
//B is current variable value of a, which is World
Console.WriteLine(b);
//prints world again.
a = "Forsbergs";
//Sets "a" value to "Forsbergs
Console.WriteLine(a); //prints Forsbergs
Console.WriteLine(b); //Prints stored value of "a", World