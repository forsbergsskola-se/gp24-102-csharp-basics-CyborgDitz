// See https://aka.ms/new-console-template for more information
Console.WriteLine("Gib seed number");
var UserSeed = int.Parse(Console.ReadLine());
Random random = new Random(UserSeed);
int a1 = random.Next(0, 5);
int a2 = random.Next(0, 5);
int a3 = random.Next(0, 5);

Console.WriteLine("first: " + a1 +
                  " second: " + a2 + 
                  " third: " + a3);
double b1 = random.NextDouble()*0.5;
double b2 = random.NextDouble()*0.5;
double b3 = random.NextDouble()*0.5;
Console.WriteLine("1st; " +b1 +
                  " second; " +b2 +
                  " third; " +b3);
double c1 = random.NextDouble()*(0.7-0.2)+0.2;
double c2 = random.NextDouble()*(0.7-0.2)+0.2;
double c3 = random.NextDouble()*(0.7-0.2)+0.2;
Console.WriteLine("1st; " +c1 +
                  " second; " +c2 +
                  " third; " +c3);

Console.WriteLine("Gib crit chance between 0 and 1%");
double Crit = double.Parse(Console.ReadLine());

for (int i = 0; i < 5; i++) {
double roll = Random.Shared.NextDouble();
bool success = roll < Crit;

 
if (success)
{
    Console.WriteLine("Crit!");
}
else
{
    Console.WriteLine("No Crit.");
}

} //for close
