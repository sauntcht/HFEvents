using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEvents
{
    internal class Fan
    {
        private int pitchNumber = 0;


        public Fan(Ball ball) => ball.BallInPlay += Ball_BallInPlayEventHandler;

        private void Ball_BallInPlayEventHandler(object? sender, EventArgs e)
        {
            pitchNumber++;

            if (e is BallEventArgs ballEventArgs)
            {
                if ((ballEventArgs.Distance > 400) && (ballEventArgs.Angle > 30))
                {
                    Console.WriteLine($"Pitch #{pitchNumber}: Fan Caught the ball");
                }
                else
                {
                    Console.WriteLine($"Pitch #{pitchNumber}: Fan is drunk and screaming");
                }
            }
        }
    }
}
