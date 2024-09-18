// See https://aka.ms/new-console-template for more ;
//test code goes below here. P09 exercises in order of appearance, skipping 00

// im confused this week lmao - Seb
//Console.WriteLine("Gimme a couple seconds, or a bunch!. In. Here. NOW! TYYPPE THEM!!");
Console.WriteLine("exercise 0.1 speedconverter"); //exercise 0.1 speedconverter
Console.WriteLine("Gimme a kilometer or two!!");
string input1 = Console.ReadLine();

int KH = Convert.ToInt32(input1);
Console.WriteLine($"Beep boop. I think this is Kilometers per hour... "+ KH);

double KHToMS = KH / 3.6; // KH to MS is roughly KH / 3.6
Console.WriteLine($"Beep boop. I think this is Meters per Second... "+ KHToMS);

Console.WriteLine("exercise 0.2 MinutesToSeconds"); //exercise 0.2 MinutesToSeconds
Console.WriteLine("Gimme a few minutes!");
string input2 = Console.ReadLine();
int Min = Convert.ToInt32(input2);

int Sec = Min * 60;
Console.WriteLine("This is seconds now! " + Sec + " seconds");

Console.WriteLine("exercise 0.3 Division"); //exercise 0.3 Division
/* Implement a program that takes two integers as input and displays their division result as a float.
Input: 11, 4
Output: 2,75 */
Console.WriteLine("Gimme TWO numbers!!");
string input3 = Console.ReadLine();
string input4 = Console.ReadLine();
float Div0 = float.Parse(input3);
float Div1 = float.Parse(input4);
Console.WriteLine(Div0 / Div1 + " Division!");

Console.WriteLine("exercise 0.4 Remainder"); //exercise 0.4 remainder
Console.WriteLine("Gimme a few numbers AGAIN!");

float Num0 = float.Parse(Console.ReadLine());
float Num1 = float.Parse(Console.ReadLine());
// Aha! like this it converts string to float value and saves the variable as a float
// It loses the readline if it was text, but we dont want to save text anyway.
// We're saving data this way by only saving the float value we need.
// If I needed I could display an error message to ask for a number value instead, maybe next time
Console.WriteLine(Num0 % Num1 + " Remainder!");

Console.WriteLine("P09_05CircleArea");
Console.WriteLine("Gimme a length in cm!");
float Len = float.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(Len, 2) * Single.Pi);
//math to the power of, Len is a value to math powers to 2

Console.WriteLine("P09_06Negation");
Console.WriteLine("Gimme number to mess with");
float NumNeg = float.Parse(Console.ReadLine());
Console.WriteLine(-NumNeg);

Console.WriteLine("P09_07Product");
Console.WriteLine("Gimme TWO more numbers please!");
int NumProd = Convert.ToInt32(Console.ReadLine()) * Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumProd);

Console.WriteLine("P09_08BMI");
Console.WriteLine("Gimme weight and height in meters, like 50kg and 1,54m!!");
float NumBMI = float.Parse(Console.ReadLine()) / MathF.Pow(float.Parse(Console.ReadLine()),2);
Console.WriteLine(NumBMI);

Console.WriteLine("P09_09Hypotenuse");
Console.WriteLine("Gib 2 sides of a triangle plix plox");
float Hypo = MathF.Sqrt( 
    MathF.Pow(float.Parse(Console.ReadLine()), 2) +
     MathF.Pow(float.Parse(Console.ReadLine()), 2));
// root of side squared + side squared code
Console.WriteLine("Hypotenuse = " + Hypo);

/*EVERYTHING BELOW THIS LINE IS SUBJECT TO TRASH 

//"input-> displayed in seconds a
// time formula = ( input / a / b / c / d) 
//minutes b = ( input / 60 )
//hours c = ( input / 60 / 60 ) -> b/=/c
//days d= ( input / 60 / 60 / 24 )

int math = Convert.ToInt32(input); //total input
int a = math; //test variable
int b = math / 60; //test variable
int c = math / (60*60); //test variable
float d = math/ (60 * 60 * 24);
//Console.WriteLine(math + (seconds % 60 ) ); // shoulds print and divide stuff - it printed the remaining digit
//Test: WriteLine(math+b). - Problem. Printed value + modulo value.
//Test: Formula update to set variable of seconds to minutes, as divided by 60
Console.WriteLine(math);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
*/


/*float seconds;
float minutes;
float hours;
float days; */

