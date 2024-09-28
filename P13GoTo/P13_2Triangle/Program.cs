// See https://aka.ms/new-console-template for more information
Console.WriteLine("How biiiig triangle eh?");
tryagain:
bool parse = int.TryParse(Console.ReadLine(), out int size);
// var tri = int.Parse(Console.ReadLine());
if (!parse) {
    Console.WriteLine("Please enter a number ya dingus!");
    goto tryagain;
}
cont:
Console.WriteLine(new string('#', size--));
// forgot how to multiply a string so i watched Fredrik's loom.
// '#', size variable with -- to reduce the number everytime it happens.
// prints it and goes to if size is above 0, do it again but with 1 less symbol.

if (size > 0) 
    goto cont;

// old test code
/*int a = 0;
repeat:
if (a != tri)
{
    Console.Write("#");
    a++;
    
    goto repeat;
}
asshole:
if */