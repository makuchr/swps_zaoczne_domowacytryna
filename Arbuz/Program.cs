using System.Drawing;

List<string> allowedSigns = ["rock", "paper", "scissors"];

int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
int expectedWins = 3;
int pointToAdd=1;

Console.WriteLine("Let's play Rock Paper Scissors, ok?");
while (true)
{
    string firstSign = GetCorrectSign("Player 1");
    string secondSign = GetRandomSign("Player 2");

    // 1. Znajdź indeks znaku podanego przez drugą osobę -> x
    int secondSignIndex = allowedSigns.IndexOf(secondSign);
    // 2. Wylicz indeks znaku, który wygrywa ze znakiem drugiej osoby -> (x + 1) % length
    int indexOfSignWinningWithSecondSign = (secondSignIndex + 1) % allowedSigns.Count;
    // 3. Znajdź indeks znaku podanego przez pierwszą osobę -> y
    int firstSignIndex = allowedSigns.IndexOf(firstSign);


    if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("It's a tie!");
    }
    // 4. Sprawdź czy indeks znaku pierwszej osoby jest równy indeksowi znaku wygrywającego
    //    ze znakiem drugiej osoby -> y == (x + 1) % l
    else if (firstSignIndex == indexOfSignWinningWithSecondSign)
    {
        Console.WriteLine("First player won!");
        firstPlayerPoints+=pointToAdd;
    }
    else
    {
        Console.WriteLine("Second player won!");
        secondPlayerPoints+=pointToAdd;
    }
    Console.WriteLine($"First player: {firstPlayerPoints}");
    Console.WriteLine($"First player: {secondPlayerPoints}");

    if (firstPlayerPoints >= expectedWins || secondPlayerPoints >= expectedWins)
    {
        break;
    }

}

string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, provide sign ({string.Join("/", allowedSigns)})");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!allowedSigns.Contains(sign))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine($"Provide correct sign! ({string.Join("/", allowedSigns)})");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }

    return sign;
}

string GetRandomSign(string playerName)
{
    int index = Random.Shared.Next(allowedSigns.Count);
    string sign = allowedSigns[index];
    Console.WriteLine($"{playerName} chosen {sign}");
    return sign;
}