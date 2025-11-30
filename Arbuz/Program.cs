Console.WriteLine("Let's play Rock Paper Scissors!");

string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((firstSign == "rock" && secondSign == "scissors")
    || (firstSign == "paper" && secondSign == "rock")
    || (firstSign == "scissors" && secondSign == "paper"))
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
    string firstSign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!(firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine("Provide correct sign! (rock/paper/scissors)");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        firstSign = Console.ReadLine()!;
    }   
    return firstSign;
}