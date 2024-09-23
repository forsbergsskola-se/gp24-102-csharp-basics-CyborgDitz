// See https://aka.ms/new-console-template for more information
Console.WriteLine("How biiiig triangle eh?");
var tri = int.Parse(Console.ReadLine());
int i = 0;
repeat:
if (i < tri) 
{
    bonus:
    Console.Write("#");
    i++;
    goto repeat;
}