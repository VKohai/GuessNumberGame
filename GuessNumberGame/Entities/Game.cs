using GuessNumberGame.Abstractions;

namespace GuessNumberGame.Entities;

public class Game : Entity
{
    private static int s_id = 1;
    public string Difficulty { get; set; }
    public DateTime BeginningOfTheGame { get; set; } = DateTime.UtcNow;
    public DateTime EndOfTheGame { get; set; }
    public IList<Player> Players { get; set; }
    public Player Winner { get; set; }
    public int SummaryPoints { get; set; } = 0;

    public Game()
    {
        Id = s_id++;
    }
}
