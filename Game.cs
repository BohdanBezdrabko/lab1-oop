using System;

public class Game
{
    public string OpponentName { get; }
    public bool IsWinner { get; }
    public int Rating { get; }
    public int GameIndex { get; }

    private static int gameCounter = 0;

    public Game(string opponentName, bool isWinner, int rating, int gameIndex)
    {
        OpponentName = opponentName;
        IsWinner = isWinner;
        Rating = rating;
        GameIndex = gameIndex;
    }
}
