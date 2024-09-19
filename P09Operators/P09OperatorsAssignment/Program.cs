// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me a nacho bunch of numbers");
float input = float.Parse(Console.ReadLine());
float d = input / (MathF.Pow(60, 2)*24);
float h = input % 86400 / 3600; // holy shit thats right
// float asdsad = input %60 ;
                          // float m = input / (60);
                          // float s = input % (60);

//first day
Console.WriteLine("days:"+(int)d);
Console.WriteLine("hours:"+(int)h);
// Console.WriteLine("minutes:"+(int)m);
// Console.WriteLine("seconds:"+(int)s);




Console.WriteLine("In total, thats "+d +" days");
