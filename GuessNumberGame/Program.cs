Random rand = new Random();
while (true)
{
    var guessNumber = rand.Next(1, 101);
    Console.WriteLine("Бот загадал число. Отгадай");
    int myNumber = -1;

    while (myNumber != guessNumber)
    {
        Console.Write("Я думаю, это число ");
        myNumber = Int32.Parse(Console.ReadLine());
        if (myNumber <= guessNumber)
        {
            Console.WriteLine("Число меньше заданного");
        } else if (myNumber >= guessNumber)
        {
            Console.WriteLine("Число больше заданного");
        }
    }
    Console.WriteLine($"Поздравляю, ты выйгриал! Это число {guessNumber}");

    Console.Write("Хочешь продолжить - нажми 1: ");
    if (Console.ReadLine() != "1")
        break;
    Console.WriteLine();
}
