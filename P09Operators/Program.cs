﻿// See https://aka.ms/new-console-template for more 

using System.Net.Mime;

Console.WriteLine("Gimme a couple seconds, or a bunch!. In. Here. NOW! TYYPPE THEM!!");
string input = Console.ReadLine();
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



/*float seconds;
float minutes;
float hours;
float days; */

