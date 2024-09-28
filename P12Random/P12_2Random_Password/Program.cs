// See https://aka.ms/new-console-template for more information
Random random = new Random();
string randomPassword = random.Next(100000,1000000).ToString();
//^ sets seed to 6 digits
Console.WriteLine("New Password: " + randomPassword);

// char password is pretty good
string chars = "qwertyuiopåasdfghjklöäzxcvbnm1234567890!?=)(/&%¤#@£$";
string password = String.Empty;
for (int i = 0; i < 6; i++)
{
    password += chars[random.Next(chars.Length)];
    
}
Console.WriteLine("Bull shit password: " + password);