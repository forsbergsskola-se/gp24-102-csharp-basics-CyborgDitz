// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Nim! Stick draw game, 1 to 3 sticks to draw");
Random random = new Random();
int matches = 24;
// string match = "|";''

goback:

Console.WriteLine($"there are this many matches: " + new string('|', matches) + $" ({matches})");
if (matches > 1)
{
    Console.WriteLine("How many matches do you draw?");
}


switch (matches)
{
    case > 1:

        retry:
        int take;
        bool success = int.TryParse(Console.ReadLine(), out take);
        if (!success)
        {
            Console.WriteLine("Enter a number between 1 and 3 please!");
            goto retry;
        }

        switch (take)
        {
            case > 3:
            case < 1:
                Console.WriteLine("Enter a number between 1 and 3 please!");
                goto goback;

        }

        reroll:
        int bot = random.Next(1, 4);
        if (bot > matches)
        {
            goto reroll;
        }
        

        matches -= take;
        if (matches == 1)
        {
            Console.Write("You win!");
            goto end;
        }
        Console.WriteLine("The ai draws " + bot + " matches.");
        matches -= bot;
        
        goto goback;
}

Console.WriteLine("you lose<3");
 end: ;   

