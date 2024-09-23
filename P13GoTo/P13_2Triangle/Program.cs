// See https://aka.ms/new-console-template for more information
Console.WriteLine("How biiiig triangle eh?");
var tri = int.Parse(Console.ReadLine());
int a = 0;
repeat:
if (a != tri)
{
    Console.Write("#");
    a++;
    
    goto repeat;
}
asshole:
if 