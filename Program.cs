Console.WriteLine("Welcome to game of snake and ladder");
int playerOnePosition = 0;
Random rnd = new Random();
int dieNum = rnd.Next(1, 7);
int playerOneCurrentPosition = dieNum + playerOnePosition;
Console.WriteLine("playerOneCurrentPosition : " + playerOneCurrentPosition);

Random random = new Random();
int snakeLadder = random.Next(1, 4);
Console.WriteLine("snakeLadder : " + snakeLadder);
    if (snakeLadder == 1)
    { Console.WriteLine("snake");
    int playerOneNewPosition = playerOneCurrentPosition - snakeLadder;
    Console.WriteLine("position : " + playerOneNewPosition);
}
else if(snakeLadder == 2)
{
    Console.WriteLine("ladder");
    int playerOneNewPosition = playerOneCurrentPosition + snakeLadder;
    Console.WriteLine("position : " + playerOneNewPosition);

}
else
    {
    Console.WriteLine("no play");
    };
