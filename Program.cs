class Program
{
    static void Main()
    {
        GameAccount player1 = new GameAccount("Player1", 1000);
        GameAccount player2 = new GameAccount("Player2", 1200);

        player1.WinGame("Player2", 50);
        player2.LoseGame("Player1", 50);

        player1.WinGame("Player2", 75);
        player2.LoseGame("Player1", 75);

        player1.GetStats();
        player2.GetStats();
    }
}
