using GuessNumberGame.Abstractions;

namespace GuessNumberGame.Entities;

public class Player : Entity
{
    private static int s_id = 1;

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
        }
    }

    private int _balance = 0;
    public int Balance
    {
        get => _balance;
        private set => _balance = value;
    }
    
    public Player(string name)
    {
        _name = name;
        Id = s_id++;
    }

    public void AddBalance(int balance)
    {
        if (balance > 0)
            _balance += balance;
    }
}
