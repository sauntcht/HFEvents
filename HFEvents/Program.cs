// See https://aka.ms/new-console-template for more information
using HFEvents;

Ball ball = new Ball();
Pitcher pitcher = new Pitcher(ball);
Fan fan = new Fan(ball);

bool gameON = true;

while (gameON)
{
    Console.WriteLine("Enter a number for angle");
    if (int.TryParse(Console.ReadLine(), out int ballAngle))
    {
        Console.WriteLine("Enter a number for distance");
        if (int.TryParse(Console.ReadLine(), out int ballDistance))
        {
            BallEventArgs ballEventArgs = new BallEventArgs(ballAngle, ballDistance);
            ball.OnBallInPlay(ballEventArgs);
        }
        else 
            gameON = false;
    }
    else
        gameON = false;

}
Console.WriteLine("Thanks for playing");