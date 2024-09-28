// See https://aka.ms/new-console-template for more information
string outputString;
float decimalValue = 0.3f; //sets float value.
bool isAwesome = true; // sets true or false value
outputString = @"Hello world!"; //@ sets multible lines for string
Console.WriteLine($"Output:" + outputString); //tring output
Console.WriteLine($"Output:" + decimalValue); //float output
Console.WriteLine($"Output:" + isAwesome); //bool output

//Learning from class
char AdamChar = 'A'; // A = 65 cuz of decimal bit or some shenanigans to DoMath. OH integer value!
char BobChar = '1'; // adds 49 for some reason to DoMath
int DoMath = AdamChar + BobChar; //adds A to 2
//Console.WriteLine(DoMath);