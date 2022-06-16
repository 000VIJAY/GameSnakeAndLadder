Console.WriteLine("Welcome to game of snake and ladder");
int playerOnePosition = 0;
Random rnd = new Random(); 
int dieNum = rnd.Next(1, 7); 
int playerOneCurrentPosition = dieNum + playerOnePosition;
Console.WriteLine("position : " + playerOneCurrentPosition);
