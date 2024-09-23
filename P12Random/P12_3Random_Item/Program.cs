// See https://aka.ms/new-console-template for more information
Random random = new Random();
int treasure = random.Next(1, 6);
switch (treasure)
{
    case 1: Console.WriteLine("You find a baguette! The most powerful bread weapon!"); 
        break;
    case 2: Console.WriteLine("You found a mushrom. Oh, you ate it. You died but get +1 life next time!");
        break;
    case 3: Console.WriteLine("You found a knife. Its useless! ");
        break;
    case 4: Console.WriteLine("You found a shield. Its a one time use so you´ll never use it!");
        break;
    case 5: Console.WriteLine("You found the key! The key to the door! Probably!");
        break;
        
}
