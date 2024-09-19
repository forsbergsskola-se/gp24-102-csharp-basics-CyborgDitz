// See https://aka.ms/new-console-template for more information
Console.WriteLine("gimme a number");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());


if (a < b && a < c)
{
    Console.WriteLine("lowest is "+ 
                      a);
}
else if (b < a && b < c)
{
    Console.WriteLine("Lowest is " +b);
}
else
{
    Console.WriteLine("lowest is " + c);
}

