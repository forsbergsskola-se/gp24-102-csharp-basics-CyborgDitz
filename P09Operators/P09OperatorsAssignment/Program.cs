// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me a nacho bunch of numbers");
float input = float.Parse(Console.ReadLine());
float d = input / (MathF.Pow(60, 2)*24);
float h = (input % 86400) / 3600; // holy shit thats right
float m = (input % 86400) % 3600 / 60; // hahahahah eurueka!
float s = input % (60); // seconds is only multibles of 60, so remainder always = seconds

Console.WriteLine("seconds:"+(int)s);
Console.WriteLine("minutes:"+(int)m);
Console.WriteLine("hours:"+(int)h);
Console.WriteLine("days:"+(int)d);
Console.WriteLine((int)d+ ":"+(int)h + ":"+(int)m+":"+(int)s);






Console.WriteLine("In total, thats "+d +" days");
