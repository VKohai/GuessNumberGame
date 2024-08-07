using GuessNumberGame;

Random rand = new Random();
var players = RegisterPlayers().ToList();
int points = 5;

while (players.Any())
{
    var (min, max) = ChooseDifficulty();
    var guessNumber = rand.Next(min, max);
    Console.WriteLine($"Бот загадал число {min} до {max - 1}.");
    int myNumber = 0;
    int playerIndex = 0;

    do
    {
        if (playerIndex == players.Count)
            playerIndex = 0;

        Console.Write($"{players[playerIndex].Name}, ваша очередь!\nЯ думаю, это число ");
        myNumber = int.Parse(Console.ReadLine());
        if (myNumber < guessNumber)
        {
            Console.WriteLine("Число меньше заданного");
        }
        else if (myNumber > guessNumber)
        {
            Console.WriteLine("Число больше заданного");
        }
        ++playerIndex;
    } while (myNumber != guessNumber);

    if (playerIndex == players.Count) --playerIndex;

    players[playerIndex].AddBalance(points);
    Console.WriteLine($"Поздравляю, {players[playerIndex].Name}, ты выйграл! Это число {guessNumber}.\n" +
        $"Ты получаешь {points} очков и твой баланс теперь {players[playerIndex].Balance}");

    playerIndex = 0;
    while (playerIndex < players.Count)
    {
        Console.Write($"{players[playerIndex].Name}, если хочешь продолжить - нажми 1: ");
        if (Console.ReadLine() != "1")
            break;
        ++playerIndex;
    }

    // Завершение игры
    if (playerIndex < players.Count) break;
    Console.WriteLine();
}

static IEnumerable<Player> RegisterPlayers()
{
    Console.Write("Регистрация участников.\n\nВведи колчество игроков: ");
    int.TryParse(Console.ReadLine(), out int amountOfPlayers);

    var players = new List<Player>();
    for (int i = 0; i < amountOfPlayers; ++i)
    {
        Console.Write($"Имя игрока №{i + 1}: ");
        var name = Console.ReadLine().Trim();
        if (string.IsNullOrEmpty(name))
        {
            --i;
            continue;
        }
        var player = new Player(name);
        players.Add(player);
    }

    return players;
}

static (int, int) ChooseDifficulty()
{
    Console.Write(
        "Выбери уровень сложности.\n\n" +
        "1.Легкий (диапазон от 1 до 50)\n" +
        "2.Средний (диапазон от 1 до 100)\n" +
        "3.Сложный (диапазон от 1 до 1000)\n" +
        "4.Свой диапазон\n" +
        "Ответ: ");

    if (int.TryParse(Console.ReadLine(), out int difficult) == false)
        return (1, 101);

    switch (difficult)
    {
        case 1:
            return (1, 51);
        case 2:
            return (1, 101);
        case 3:
            return (1, 1001);
        default:
            Console.Write("\nЧерез пробел введи мин. и макс. пределы диапазона: ");
            var (min, max) = Console.ReadLine().Split() switch { var data => (data[0], data[1]) };
            return (int.Parse(min), int.Parse(max) + 1);
    }
}