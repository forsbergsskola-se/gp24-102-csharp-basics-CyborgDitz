// See https://aka.ms/new-console-template for more information
Console.WriteLine("Age please?");
var age = Convert.ToInt32(Console.ReadLine());
bool isChild = 12>= age; // check if age below 12 bool
bool isTeen = 13 <= age && age <= 19; // check if age between 13 and 19 bool
bool isAdult = 20 <= age; // check if age is above 19
Console.WriteLine($"You are a Child: {isChild}");
Console.WriteLine($"You are a Teenager: {isTeen}");
Console.WriteLine($"You are an Adult: {isAdult}");