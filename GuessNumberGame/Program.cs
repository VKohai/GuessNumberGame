Random rand = new Random();
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
    }
    else if (myNumber >= guessNumber) {
        Console.WriteLine("Число больше заданного");
    }
}
Console.WriteLine($"Поздравляю, ты выйгриал! Это число {guessNumber}");