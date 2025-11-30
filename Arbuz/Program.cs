Console.WriteLine("Let's play Rock-Paper-Scissors!");

Console.WriteLine("Choose your sign, pleyr 1 (rock/paper/scissors):");
string firstSign = Console.ReadLine()!;

Console.WriteLine("Choose your sign, pleyr 2 (rock/paper/scissors):");
string secondSign = Console.ReadLine()!;

if (firstSign.Equals(secondSign, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("It's a draw!");
}
else if ((firstSign.Equals("rock", StringComparison.CurrentCultureIgnoreCase) && secondSign.Equals("scissors", StringComparison.CurrentCultureIgnoreCase))
    || (firstSign.Equals("scissors", StringComparison.CurrentCultureIgnoreCase) && secondSign.Equals("paper", StringComparison.CurrentCultureIgnoreCase))
    || (firstSign.Equals("paper", StringComparison.CurrentCultureIgnoreCase) && secondSign.Equals("rock", StringComparison.CurrentCultureIgnoreCase)))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}