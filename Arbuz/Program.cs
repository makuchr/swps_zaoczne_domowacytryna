List<string> allowedSigns = ["rock", "paper", "scissors"];

Console.WriteLine("Let's play Rock Paper Scissors!");

string sign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

if (sign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((sign == allowedSigns[0] && secondSign == allowedSigns[2])
    || (sign == allowedSigns[1] && secondSign == allowedSigns[0])
    || (sign == allowedSigns[2] && secondSign == allowedSigns[1]))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}




string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, provide sign ({string.Join("/",allowedSigns)})");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!allowedSigns.Contains(sign))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine($"Provide correct sign! ({string.Join("/",allowedSigns)})");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }   
    return sign;
}