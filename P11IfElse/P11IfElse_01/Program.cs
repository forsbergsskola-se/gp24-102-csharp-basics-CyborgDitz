// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me your test score and I will grade you!");
var input  = Convert.ToInt32(Console.ReadLine());
if (input >= 90 )
{ 
    Console.WriteLine( input <= 100 ?"You get an A!" : "You are cheating!");
    
}

if (input >= 80 && input <= 89)
{
    Console.WriteLine("You get an B!");
}

if (input >= 70 && input <= 79)
{
    Console.WriteLine("You get an C!");
}

if (input >= 60 && input <= 69 /*nice*/)
{
    Console.WriteLine("You get an D!");
}

if (input < 60)
{
    Console.WriteLine("You get an F! E doesnt exist fuck you!");
}

if (input < 10)
{
    Console.WriteLine("You get a SUPER F! *big industry sized F print on pape*");
}