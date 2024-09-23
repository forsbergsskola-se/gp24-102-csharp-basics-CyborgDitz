// See https://aka.ms/new-console-template for more information
Random random = new Random();
string randomPassword = random.Next(100000,999999).ToString();
//^ sets seed to 6 digits
Console.WriteLine("New Password: " + randomPassword);
