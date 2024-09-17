// See https://aka.ms/new-console-template for more 

using System.Net.Mime;

Console.WriteLine("Gimme a couple seconds, or a bunch!. In. Here. NOW! TYYPPE THEM!!");
string input = Console.ReadLine();
//"input-> displayed in seconds a
// time formula = ( input / a / b / c / d) 
//minutes b = ( input / 60 )
//hours c = ( input / 60 / 60 ) -> b/=/c
//days d= ( input / 60 / 60 / 24 )

float math = float.Parse(input);
float seconds = math % 60;
Console.WriteLine(seconds); // shoulds print and divide stuff



/*float seconds;
float minutes;
float hours;
float days; */

