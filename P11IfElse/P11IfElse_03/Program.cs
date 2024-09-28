// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type a singel character!");
string input = Console.ReadLine();
// string isVowel = input;

//clarifying that i tested switches for the first time
switch (input)
{ //checks wowel
    case "a": 
    case "e":
    case "i":
    case "o":
    case "u": 
    case "y": 
    case "å": 
    case "ä": 
    case "ö":
        Console.WriteLine("THAS A VOWEL MATE!");
        break;
    //checks consonant
    case "b":
    case "c":
    case "d":
    case "f":
    case "g":    
    case "h":
    case "j":
    case "k":
    case "l":
    case "m":
    case "n":
    case "p":
    case "q":
    case "r":
    case "s":
    case "t":
    case "v":
    case "w":
    case "x":
    case "z":
        Console.WriteLine("THAS A CONSONONTOTONONR MATE!");
        break;
    
    //checks numbero
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
    case "6":
    case "7":
    case "8":
    case "9":
    case "0":
        
        Console.WriteLine("THAS A NUMBRE BOZO!");
        break;
    
             }  



