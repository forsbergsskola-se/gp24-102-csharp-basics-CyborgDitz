// See https://aka.ms/new-console-template for more information
Console.WriteLine("I picked a number (1-100), guess it");
Random random = new Random();
int x = random.Next(1, 100);

string wrong1 = "My answer is Greater!";
string wrong2 = "My answer is Lower!";
string answer = "Thats right!";

goback:
int guess = int.Parse(Console.ReadLine());

if (guess == x) {
    Console.WriteLine(answer);
}
else if (guess < x)
{ Console.WriteLine(wrong1); }
else if (guess > x)
{ Console.WriteLine(wrong2);
    
}
goto goback;
// output--;
// if (output > 0)
// {
//     goto goback;
// }