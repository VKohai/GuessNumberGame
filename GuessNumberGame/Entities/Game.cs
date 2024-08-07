using GuessNumberGame.Abstractions;

namespace GuessNumberGame.Entities;

public class Game : Entity
{
    private static int s_id = 0;
    public string Difficulty { get; set; }
    public DateTime BeginningOfTheGame { get; set; }
    public DateTime EndOfTheGame { get; set; }
    public IList<Player> Players { get; set; }
    public Player Winner { get; set; }
    public int SummaryPoints { get; set; }

    public Game(string difficulty, IList<Player> players, Player winner, int summaryPoints)
    {
        Id = s_id++;
        Difficulty = difficulty;
        Players = players;
        Winner = winner;
        SummaryPoints = summaryPoints;
    }
}
