Console.WriteLine("Let's play Rock Paper Scissors!");

string sign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

if (sign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((sign == "rock" && secondSign == "scissors")
    || (sign == "paper" && secondSign == "rock")
    || (sign == "scissors" && secondSign == "paper"))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}




string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, provide sign (rock/paper/scissors)");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!(sign == "rock" || sign == "paper" || sign == "scissors"))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine("Provide correct sign! (rock/paper/scissors)");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }   
    return sign;
}