// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your age?");
var age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("You are an adult!");
}

if (age < 18 && age >=13)
{
    Console.WriteLine("You are a teen!");
}

if (age <= 12 && age >0)
{
    Console.WriteLine("You are a child!");
}
if (age <=0) {
    Console.WriteLine("What... What are you?!");
}
Console.WriteLine("Gimme another integer plix plox.");
var gimme = Convert.ToInt32(Console.ReadLine());
if (gimme > age)
{
    Console.WriteLine("The greater of the two is the integer: " + gimme);
    Console.WriteLine(gimme % 2 == 0 ? "That is an even number" : "That is an odd number" );
}



if (gimme < age)
{
    Console.WriteLine("The greater of the two is  your age: age " + age);
    Console.WriteLine(age % 2 == 0 ? "That is an even number" : "That is an odd number");
}


