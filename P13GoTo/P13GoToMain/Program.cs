// See https://aka.ms/new-console-template for more information
Console.WriteLine("I picked a number (1-100), guess it");
Random random = new Random();
int x = random.Next(1, 100);

string wrong1 = "My answer is Greater!";
string wrong2 = "My answer is Lower!";
string answer = "That's right!";
int counter = 10;


goback:
int guess = int.Parse(Console.ReadLine());
counter--; // counts time timer every repeat and if checks if bool counter isn't 0
if (guess == x && counter > 0) {
    Console.WriteLine(answer);
    
}
else if (guess < x && counter > 0)
{
    Console.WriteLine(wrong1);

}
else if (guess > x && counter > 0)
{ Console.WriteLine(wrong2);
    
}


if (counter > 0)
{
    Console.WriteLine("You have " + counter + " guesses left");
    goto goback;
} 

Console.WriteLine("You lose!");






