// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a size");

string patOne = "-#-#-#-#-#";
string patTwo = "#-#-#-#-#-";

int output = int.Parse(Console.ReadLine());

goback:

if (output % 2 ==0) {
    Console.WriteLine(patOne);
    }
    else { Console.WriteLine(patTwo); }

    output--;
    if (output > 0)
    {
        goto goback;
    }
     
     