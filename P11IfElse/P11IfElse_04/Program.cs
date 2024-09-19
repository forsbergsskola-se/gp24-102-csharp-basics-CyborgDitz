// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type something then do something then type something");
int input1 = int.Parse(Console.ReadLine());
string Minput = Console.ReadLine();
int input2 = int.Parse(Console.ReadLine());

switch (Minput)
{
    case "+":
        Console.WriteLine(input1 + input2);
        break;
    case "-":
        Console.WriteLine(input1 - input2);
        break;
    case "/":
        Console.WriteLine(input1 / input2);
        break;
    case "*":
        Console.WriteLine(input1 * input2);
        break;
}