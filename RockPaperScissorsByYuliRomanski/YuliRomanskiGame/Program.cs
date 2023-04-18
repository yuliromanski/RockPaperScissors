const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Random random = new Random();
int PcRandomNumber = random.Next(1, 4);
string PCAction = "";

Console.Write("Choose [r]rock, [p]paper or [s]scissors: ");
string Action = Console.ReadLine();

if (Action == "r")
{
    Action = Rock;
}

else if (Action == "p")
{
    Action = Paper;
}
else if (Action == "s")
{
    Action = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
    return;
}
switch (PcRandomNumber)
{
    case 1:
        PCAction = Rock;
        break;

    case 2:
        PCAction = Paper;
        break;

    case 3:
        PCAction = Scissors;
        break;
}
Console.WriteLine($"The computer choose {PCAction}.");
if ((Action == Rock && PCAction == Scissors) ||
       (Action == Paper && PCAction == Rock) ||
       (Action == Scissors && PCAction == Paper))
{
    Console.WriteLine("You win");
}
else if ((Action == Rock && PCAction == Paper) ||
    (Action == Paper && PCAction == Scissors) ||
    (Action == Scissors && PCAction == Rock))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("Ths game was a draw.");
}