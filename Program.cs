using System.Security.Cryptography;
string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890&é()§è!çà{[$@#]}?/:";
byte symbolslength = (byte)symbols.Length;
Console.Write("How long do you want your password to be (255 max): ");
try{
    byte pwlength = Convert.ToByte(Console.ReadLine());
    string password = "";
    for (int i = 0;i<pwlength;i++){
        password = password + symbols[RandomNumberGenerator.GetInt32(0,symbolslength)];
    }
    Console.WriteLine($"Your password is: {password}");
}
catch{
    Console.WriteLine("Incorrect password length");
}