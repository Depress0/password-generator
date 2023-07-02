// See https://aka.ms/new-console-template for more information
string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890&é()§è!çà{[$@#]}?/:";
byte symbolslength = (byte)symbols.Length;
Console.Write("How long do you want your password to be (255 max): ");
try{
    byte pwlength = Convert.ToByte(Console.ReadLine());
    Random random = new Random();
    string password = "";
    for (int i = 0;i<pwlength;i++){
        password = password + symbols[random.Next(0,symbolslength)];
    }
    Console.WriteLine($"Your password is: {password}");
}
catch{
    Console.WriteLine("Incorrect password length");
}