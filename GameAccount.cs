using System;
using System.Collections.Generic;

public class GameAccount
{
    public string UserName { get; private set; }
    public int CurrentRating { get; private set; }
    public int GamesCount { get; private set; }
    private List<Game> gamesHistory;

    public GameAccount(string userName, int initialRating)
    {
        if (initialRating < 0)
            throw new ArgumentException("Initial rating cannot be negative.");

        UserName = userName;
        CurrentRating = initialRating;
        GamesCount = 0;
        gamesHistory = new List<Game>();
    }

    public void WinGame(string opponentName, int rating)
    {
        ValidateRating(rating);

        CurrentRating += rating;
        GamesCount++;

        gamesHistory.Add(new Game(opponentName, true, rating, GamesCount));
    }

    public void LoseGame(string opponentName, int rating)
    {
        ValidateRating(rating);

        CurrentRating = Math.Max(1, CurrentRating - rating);
        GamesCount++;

        gamesHistory.Add(new Game(opponentName, false, rating, GamesCount));
    }

    public void GetStats()
    {
        Console.WriteLine($"Game history for {UserName}:");
        Console.WriteLine("Opponent\tOutcome\tRating\tGame Index");

        foreach (var game in gamesHistory)
        {
            Console.WriteLine($"{game.OpponentName}\t\t{(game.IsWinner ? "Win" : "Loss")}\t\t{game.Rating}\t\t{game.GameIndex}");
        }
    }

    private void ValidateRating(int rating)
    {
        if (rating < 0)
            throw new ArgumentException("Rating cannot be negative.");
    }
}
